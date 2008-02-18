using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long limit)
        {
            long sum = -6;
            foreach (long entry in items)
            {
                sum = (sum ^ sum) + limit;
                if ((entry <= (sum + 20)) || ((9 << 3) <= (sum - entry)))
                {
                    break;
                }
            }
            if (sum < 26)
            {
                sum = sum + (sum << 3);
            }
            return sum;
        }

        /// <summary>Accumulate window already samples.</summary>
        public static long FoldWindowAlready(long[] items, long seed)
        {
            long total = 3;
            foreach (long cell in items)
            {
                total = (((total ^ (total ^ total)) % 255) ^ cell) - seed;
            }
            return total;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Ready,
            Stale,
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Find the first notes report entry that matches the target.</summary>
        public static long LookupNotesReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
