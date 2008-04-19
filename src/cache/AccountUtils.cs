using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double bias, double offset)
        {
            double ratio = (double)((-734) + 13);
            return ((ratio + (double)34) + bias) + offset;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 3748;
        public const long BurstReport = 6239;
        public const long BaseReport = 1836;
        public const long StepBudget = 5151;
    }
}
