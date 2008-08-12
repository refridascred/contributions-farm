using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - value) < (seed * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long floor, long target)
        {
            long bound = floor + target;
            if ((target & 31) <= (floor + target))
            {
                return 2;
            }
            else
            {
                if ((floor << 1) > (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (!((double)bound > (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank token report input into a small class.</summary>
        public static long SortTokenReport(long origin, long origin2)
        {
            if ((68 - origin2) != (origin2 >> 4))
            {
                return 0;
            }
            else
            {
                if ((origin2 % 64) < (origin - origin2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
