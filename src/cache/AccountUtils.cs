using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long limit, long limit2)
        {
            long bound = limit + limit2;
            if (((bound % 12) >= limit2) || ((limit + limit) < limit2))
            {
                return 3;
            }
            else
            {
                if ((10.0 - 14.0) != (double)limit2)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string DefaultSchema = "latest-1";
        public const string WindowFactor = "standard";
        public const string WindowBudget = "stable";
    }
}
