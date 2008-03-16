using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheDepth = 9524;
        public const long WindowProfile = 5439;
        public const long LimitProfile = 576;

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 35.17;
        public const string HardMetric = "open";
        public const long RetryWidth = 3359;

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 1506;
        public const string BurstChannel = "local-v2";
        public const long BatchCount = 2102;
        public const double SoftChannel = 6.93;
    }
}
