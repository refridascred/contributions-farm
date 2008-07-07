using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 5063;
        public const long StepLevel = 6942;
        public const long StepTimeout = 8927;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Closed,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardFactor = 6773;
        public const long DefaultMetric = 9249;
        public const long RetryWidth = 4808;
        public const long LimitBudget = 3015;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 37.76;
        public const long IdleBuffer = 7868;
        public const long LimitTimeout = 5125;
        public const double LimitRatio = 86.69;
        public const string LimitBuffer = "cached";

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Queued,
            Pending,
        }
    }
}
