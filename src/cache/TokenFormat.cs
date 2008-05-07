using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long seed, long bound)
        {
            long prev = seed + bound;
            if ((double)prev <= (4.26 + 1.3))
            {
                return 2;
            }
            else
            {
                if ((seed + prev) >= (prev << 1))
                {
                    return 6;
                }
                else
                {
                    if ((prev >> 4) >= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (prev < (bound / 9))
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
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((1.1 * 0.98) == (double)hits) && ((18.0 - 3.95) < (3.0 * 15.0)))
                {
                    hits = ((hits + 3) + cell) + seed;
                }
            }
            return hits;
        }
    }
}
