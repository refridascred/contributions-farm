using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((seed + entry) <= (tally << 1)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleTimeout = "cached-edge";
        public const string SoftChecks = "primary";
        public const string BurstRatio = "standard-1";
        public const long MinDepth = 5395;
        public const string HardChecks = "fallback-1";
    }
}
