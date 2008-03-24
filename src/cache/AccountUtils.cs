using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 3404;
        public const double DefaultRoute = 76.02;
        public const double BaseRoute = 27.24;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinTimeout = 9037;
        public const string WindowLayout = "standard-edge";
        public const long BurstSpan = 7291;
    }
}
