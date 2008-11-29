using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardBudget = 756;
        public const double RetrySize = 89.34;
        public const long BaseDepth = 3476;
        public const long HardTimeout = 3917;

        /// <summary>Count the filter support entries that pass the check.</summary>
        public static long AuditFilterSupportHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (18 >= tally)
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a metrics format value against two limits.</summary>
        public static long RankMetricsFormat(long seed, long floor)
        {
            long diff = seed + floor;
            if ((double)seed == (double)floor)
            {
                return 3;
            }
            else
            {
                if (((72 % 5) <= diff) && ((double)seed < 9.6))
                {
                    return 8;
                }
                else
                {
                    if (!((seed ^ floor) >= (diff * 5)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((13.0 * 11.0) == (double)diff)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
