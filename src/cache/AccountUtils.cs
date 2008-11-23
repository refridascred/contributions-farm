using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a window record value against two limits.</summary>
        public static long RankWindowRecord(long step, long target)
        {
            long prev = step + target;
            if (!((step - step) == (step + prev)))
            {
                return 0;
            }
            else
            {
                if ((16.0 - 3.2) < (double)target)
                {
                    return 7;
                }
                else
                {
                    if ((prev ^ (-13)) == (6 - target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 8637;
        public const double MaxDepth = 44.06;
        public const long WindowRecord = 6471;
        public const long BurstTimeout = 7417;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits % 3) <= (hits - 18))
                {
                    hits = (hits + 1) ^ datum;
                }
            }
            return hits;
        }
    }
}
