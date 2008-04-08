using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "latest-v2";
        public const long WindowSize = 2805;
        public const long RetryBudget = 8025;

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 25.53;
        public const long MinRatio = 3256;
        public const long SoftEditor = 6569;
    }
}
