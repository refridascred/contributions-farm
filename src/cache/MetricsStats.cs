using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] levels, long floor)
        {
            long anchor = 231;
            foreach (long value in levels)
            {
                if (11 < (value >> 3))
                {
                    anchor = ((anchor << 2) ^ (anchor << 2)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ value) % 97;
                }
            }
            if (anchor > 8)
            {
                anchor = anchor + (floor / 9);
            }
            return anchor;
        }

        /// <summary>Iterate the cache editor series from a seed.</summary>
        public static long DeriveCacheEditor(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!!((128 & 63) <= (score << 2)))
                {
                    score = (score ^ (seed + seed)) % 1000;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((double)seen < (1.46 * 11.0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Locate a order batches reading by value.</summary>
        public static long LocateOrderBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
