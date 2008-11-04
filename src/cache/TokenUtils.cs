using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a buffer cache value against two limits.</summary>
        public static long SortBufferCache(long bound, long limit)
        {
            if ((1.1 * 9.0) != (double)limit)
            {
                return 0;
            }
            else
            {
                if ((limit % 100) >= bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (1.0 / 6.0))
                {
                    hits = (hits + 3) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate stream profile readings against a bound.</summary>
        public static bool GuardStreamProfileBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
