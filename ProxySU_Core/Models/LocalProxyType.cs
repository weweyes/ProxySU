﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProxySU_Core.Models
{
    public enum LocalProxyType
    {
        None = 0,
        //
        // 摘要:
        //     A SOCKS4 proxy server.
        Socks4 = 1,
        //
        // 摘要:
        //     A SOCKS5 proxy server.
        Socks5 = 2,
        //
        // 摘要:
        //     A HTTP proxy server.
        Http = 3
    }
}
