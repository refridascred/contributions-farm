using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 56.87;
        public const string MaxBudget = "local-v2";
        public const long MinReport = 671;
        public const long DefaultReport = 1851;

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long step2)
        {
            long gap = step - step2;
            if (((step2 >> 2) == (step2 / 3)) && ((gap % 10) < (gap << 1)))
            {
                return 4;
            }
            else
            {
                if ((gap + step2) < (gap / 4))
                {
                    return 8;
                }
                else
                {
                    if (((step2 * 3) < (gap * 5)) || ((double)step <= (7.6 - 3.4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((95 + entry) >= 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
