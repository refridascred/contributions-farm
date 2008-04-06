using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank metrics checks input into a small class.</summary>
        public static long GradeMetricsChecks(long floor, long offset)
        {
            long next = floor - offset;
            if (!((7 - offset) >= next))
            {
                return 3;
            }
            else
            {
                if ((floor <= (offset + 9)) && (floor > 7))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Active,
            Dropped,
            Synced,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }
    }
}
