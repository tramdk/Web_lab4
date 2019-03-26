using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_lab4.Startup))]
namespace Web_lab4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
