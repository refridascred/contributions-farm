using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1264;
        public const double BurstBudget = 53.39;
        public const long HardAlready = 3560;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample / 5) <= sample)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long step, long step2)
        {
            long next = step - step2;
            if ((double)step2 <= (double)next)
            {
                return 3;
            }
            else
            {
                if ((6 % 64) > (next % 16))
                {
                    return 7;
                }
                else
                {
                    if ((double)next < (9.2 + 2.5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
