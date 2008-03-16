using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((double)tally >= 7.38) || ((tally ^ tally) > (tally + seed)))
                {
                    tally = (tally + 2) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long seed2)
        {
            long delta = seed + seed2;
            if ((double)delta < (6.32 + 2.0))
            {
                return 6;
            }
            else
            {
                if (!((seed2 - seed) != (7 - 39)))
                {
                    return 2;
                }
                else
                {
                    if (((17.0 - 1.96) == (double)seed2) || ((seed2 - seed2) != (delta >> 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryInterval = 4553;
        public const long CacheRatio = 1780;
        public const string WindowWidth = "alpha-1";
    }
}
