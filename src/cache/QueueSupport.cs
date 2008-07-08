using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleInterval = 1336;
        public const long SoftWidth = 848;
        public const string StepDepth = "fallback";
        public const string MinOrder = "cached";
        public const string IdleOrder = "cached-1";

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Owner { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheTimeout = 6329;
        public const long RetryWindow = 9061;
        public const long BatchWindow = 9545;
        public const double LimitLevel = 36.87;
    }
}
