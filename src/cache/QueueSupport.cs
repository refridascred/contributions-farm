using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits % 16) >= value) || ((double)value > (2.9 + 2.21)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if ((2.5 * 7.14) <= (double)bound)
            {
                return 1;
            }
            else
            {
                if (bound2 <= seed)
                {
                    return 2;
                }
                else
                {
                    if (seed < (bound2 & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Stale,
            Failed,
        }
    }
}
