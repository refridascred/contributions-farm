using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 5782;
        public const double LimitDepth = 74.77;
        public const string CacheBuffer = "strict-edge";
        public const long RetryLevel = 3782;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 42.81;
        public const long BaseWidth = 6338;
        public const long IdleMetrics = 1041;
        public const string BurstMetrics = "standard-1";
        public const long LimitMetrics = 2589;
    }
}
