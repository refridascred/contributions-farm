using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Dropped,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] items)
        {
            long score = 617;
            foreach (long entry in items)
            {
                if ((entry & 7) == (entry % 12))
                {
                    score = (score ^ (entry + score)) % 101;
                }
            }
            if (score < 3)
            {
                score = (score * 2) + (6 * 4);
            }
            return score % 4096;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long floor, long offset)
        {
            if ((0 + offset) <= (floor + floor))
            {
                return 5;
            }
            else
            {
                if (!(floor <= (410 + offset)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
