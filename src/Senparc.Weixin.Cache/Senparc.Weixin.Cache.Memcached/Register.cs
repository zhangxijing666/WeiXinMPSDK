﻿#if NETCOREAPP2_0 || NETCOREAPP2_1
using Microsoft.AspNetCore.Builder;
#endif

namespace Senparc.Weixin.Cache.Memcached
{
    public static class Register
    {
#if NETCOREAPP2_0 || NETCOREAPP2_1
     /// <summary>
        /// 注册 Senparc.Weixin.Cache.Memcached
        /// </summary>
        /// <param name="app"></param>
        public static IApplicationBuilder UseSenparcWeixinCacheMemcached(this IApplicationBuilder app)
        {
            app.UseEnyimMemcached();
            RegisterDomainCache();
            return app;
        }
#endif


        /// <summary>
        /// 注册领域缓存
        /// </summary>
        public static void RegisterDomainCache()
        {
            var cache = MemcachedContainerCacheStrategy.Instance;
        }

    }
}
