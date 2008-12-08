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

        /// <summary>Match up window format samples.</summary>
        public static long PairWindowFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
