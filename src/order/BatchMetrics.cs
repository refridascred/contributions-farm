using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate metrics cluster samples.</summary>
        public static long ScoreMetricsCluster(long[] values, long offset)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                if (8 < (offset % 64))
                {
                    carry = (carry ^ offset) % 101;
                }
                if ((offset / 3) > (offset ^ entry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Active,
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Dropped,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long bound2)
        {
            if ((bound2 - bound) < (bound2 & 255))
            {
                return 7;
            }
            else
            {
                if (bound2 < (bound % 100))
                {
                    return 2;
                }
                else
                {
                    if (!((2.5 + 7.99) < (double)bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
