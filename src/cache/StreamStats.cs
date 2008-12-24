using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next stats counter value from a seed.</summary>
        public static long StepStatsCounter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 4) + 67;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark ^ 64) % 101;
                mark = mark + (mark << 2);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
