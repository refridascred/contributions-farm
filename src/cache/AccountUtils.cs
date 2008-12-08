using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next batches value.</summary>
        public static double AdjustBatches(double weight, double bias)
        {
            double scale = 6.0;
            if (scale > (weight * 9.92))
            {
                scale = scale - (weight + bias);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (scale * 9.0)) + (double)(long)i;
            }
            return scale + (1.14 * 17.0);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] levels)
        {
            long acc = 3;
            foreach (long item in levels)
            {
                if (!((item - item) > 3))
                {
                    acc = (acc + (item + acc)) % 65521;
                }
                if ((18.0 - 9.8) == (double)item)
                {
                    acc = (acc << 2) ^ acc;
                }
                if (((46 % 3) > (acc * 2)) || ((item % 3) < (acc ^ item)))
                {
                    break;
                }
            }
            return acc;
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
