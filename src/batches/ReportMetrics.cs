using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSize = 3334;
        public const long MaxAccount = 9034;
        public const long LimitAccount = 1925;
        public const long RetryTimeout = 6824;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long target, long step)
        {
            if ((target > 49) || (step > (target ^ step)))
            {
                return 7;
            }
            else
            {
                if (target <= ((-58) * 4))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
