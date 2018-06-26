using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Threax.ReflectedServices
{
    public interface IServiceSetup
    {
        void ConfigureServices(IServiceCollection services);
    }
}
