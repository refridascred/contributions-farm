using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long bound, long bound2)
        {
            if (((251 + bound2) < (bound2 ^ bound2)) && ((bound - bound) == (71 + bound)))
            {
                return 6;
            }
            else
            {
                if (bound > bound2)
                {
                    return 3;
                }
                else
                {
                    if (bound <= (0 & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Queued,
            Paused,
            Closed,
            Active,
        }
    }
}
