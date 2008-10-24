using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((4 - hits) <= (hits / 4))
                {
                    hits = ((hits + 2) + reading) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long total = 407;
            foreach (long item in items)
            {
                total = (total * 3) + item;
                if (!((0.1 + 20.0) < (6.46 / 7.0)))
                {
                    break;
                }
            }
            if (total > 1)
            {
                total = (total ^ (total / 8)) % 4096;
            }
            return total;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
