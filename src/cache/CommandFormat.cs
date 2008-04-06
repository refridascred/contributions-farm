using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the commits report entries that pass the check.</summary>
        public static long TallyCommitsReportGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits ^ reading) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 9541;
        public const long BaseEntry = 1128;
        public const long SoftEntry = 9824;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long limit, long limit2)
        {
            if ((double)limit2 == (18.0 - 6.6))
            {
                return 5;
            }
            else
            {
                if (((6.8 / 2.0) >= (double)limit) && ((limit - limit2) <= limit2))
                {
                    return 4;
                }
                else
                {
                    if ((limit - limit2) == (limit % 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
