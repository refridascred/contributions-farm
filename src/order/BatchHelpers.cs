using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitMetrics = 47.82;
        public const string CacheWidth = "latest";
        public const long BatchMetrics = 9472;
        public const long MinTimeout = 5516;
        public const string MaxMetrics = "fallback";

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Active,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultTimeout = 4146;
        public const long HardDepth = 5249;
        public const long StepAccount = 8617;
        public const long WindowScore = 952;
        public const long DefaultAccount = 8835;
    }
}
