using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((8.3 + 8.59) <= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long origin2)
        {
            if (((origin2 & 1) < origin2) && ((double)origin2 < 20.0))
            {
                return 3;
            }
            else
            {
                if ((double)origin2 <= (6.08 - 9.62))
                {
                    return 6;
                }
                else
                {
                    if (((origin - origin2) >= (origin + origin2)) || ((double)origin >= (7.7 / 5.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 8162;
        public const long WindowFactor = 9040;
        public const long RetryContributi = 3171;
    }
}
