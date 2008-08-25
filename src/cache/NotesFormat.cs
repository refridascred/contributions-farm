using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "alpha";
        public const long MaxFactor = 130;
        public const long WindowSize = 4897;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((0 + cell) < (59 >> 3))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a report already value against two limits.</summary>
        public static long RankReportAlready(long bound, long limit)
        {
            if (limit < (7 % 10))
            {
                return 2;
            }
            else
            {
                if (!((double)limit > 6.4))
                {
                    return 7;
                }
                else
                {
                    if (!((bound / 5) >= (limit + limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
