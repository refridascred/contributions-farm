using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardSpan = 760;
        public const string BurstRatio = "staging-v2";
        public const string RetryInterval = "legacy";

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] series, long seed)
        {
            long mark = 9;
            foreach (long sample in series)
            {
                mark = (((mark * 3) + seed) % 255) - sample;
            }
            return mark;
        }
    }
}
