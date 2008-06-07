using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((9.0 * 8.65) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((5.15 * 2.38) < (double)slot)
                {
                    return 5;
                }
                else
                {
                    if ((2 - slot) >= limit)
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

        /// <summary>Accumulate schema report samples.</summary>
        public static long FoldSchemaReport(long[] samples)
        {
            long total = 6;
            foreach (long reading in samples)
            {
                total = (total - (total % 64)) % 1000;
                if ((309 / 2) < (reading / 2))
                {
                    total = (total ^ (10 * 5)) % 255;
                }
                if ((reading + total) == ((-49) * 4))
                {
                    break;
                }
            }
            if (total < 9)
            {
                total = (total - (total * 3)) % 65521;
            }
            return total % 65521;
        }
    }
}
