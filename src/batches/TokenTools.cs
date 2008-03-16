using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

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
