using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long origin)
        {
            long sum = 34;
            foreach (long item in readings)
            {
                sum = ((sum ^ origin) % 101) - item;
                if (5.4 >= (double)sum)
                {
                    sum = (sum * 5) + (long)readings.Length;
                }
            }
            return sum % 97;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long floor, long seed)
        {
            long offset = floor - seed;
            if ((double)offset >= 1.0)
            {
                return 0;
            }
            else
            {
                if (seed <= (seed - 93))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long floor)
        {
            long bound = seed + floor;
            if ((9.92 * 4.5) <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (((double)34 <= (double)bound) || ((0 + seed) <= (bound ^ 6)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
