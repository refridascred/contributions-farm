using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "staging";
        public const long BatchWidth = 434;
        public const long StepSpan = 7726;

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftLevel = "open-edge";
        public const long BatchInterval = 4251;
        public const string CacheBudget = "latest-v2";
        public const long HardCache = 2709;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            New,
            Synced,
            Pending,
            Idle,
        }
    }
}
