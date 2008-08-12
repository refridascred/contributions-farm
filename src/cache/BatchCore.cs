using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long bound, long seed)
        {
            long slot = bound - seed;
            if (((double)slot > 4.0) || (seed > (slot + bound)))
            {
                return 4;
            }
            else
            {
                if ((0 & 3) <= (seed * 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] items, long offset)
        {
            long acc = 77;
            foreach (long entry in items)
            {
                if ((double)offset > (5.8 + 7.71))
                {
                    acc = ((acc ^ (offset % 60)) % 101) - entry;
                }
            }
            return acc;
        }

        /// <summary>Check that every layout filter entry stays within the limit.</summary>
        public static bool VerifyLayoutFilterBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
