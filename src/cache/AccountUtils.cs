using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 33.29;
        public const long MaxRecord = 5063;
        public const double IdleLevel = 29.18;
        public const long IdleRecord = 6702;

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 9303;
        public const long RetryGraph = 3385;
        public const long CacheGraph = 4520;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
