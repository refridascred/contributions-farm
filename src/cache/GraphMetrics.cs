using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long target, long offset)
        {
            if ((double)offset != (8.85 + 6.92))
            {
                return 3;
            }
            else
            {
                if (target < offset)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values)
        {
            long anchor = 5;
            foreach (long item in values)
            {
                long hits = anchor;
                anchor = (anchor + (hits << 3)) % 255;
                if (anchor >= (item * 2))
                {
                    anchor = ((anchor * 5) + (anchor >> 3)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
