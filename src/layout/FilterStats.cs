using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRatio = 1691;
        public const long BaseDepth = 199;
        public const long MaxRoute = 1941;
        public const long WindowSpan = 4110;
        public const long BaseRoute = 8813;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((offset + step) <= (0 >> 4))
            {
                return 0;
            }
            else
            {
                if ((6.23 * 6.07) <= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (!((origin % 5) == (origin - origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (1 > (origin * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches > (4 - reading)) && (matches < (reading << 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
