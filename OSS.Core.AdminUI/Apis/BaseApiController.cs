﻿using Microsoft.AspNetCore.Mvc;
using OSS.Infrastructure.Utils;
using OSS.Infrastructure.Web.Middlewares.Web;
using OSS.Infrastructure.Web.Middlewares.Web.Auth;

namespace OSS.Core.AdminUI.Apis
{
    /// <summary>
    /// 接口控制器基类
    /// </summary>
    [WebApiAjax]
    [WebAdminAuth]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BaseApiController:ControllerBase
    {
 
    }


    #region 系统配置信息

    /// <summary>
    /// 系统基础信息
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class SysController : ControllerBase
    {
        /// <summary>
        ///   获取系统版本
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Opv()
        {
            return AppInfoUtil.AppVersion;
        }
    }

    #endregion


}