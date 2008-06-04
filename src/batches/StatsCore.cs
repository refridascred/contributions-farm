using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits >= (target + target)) && !((datum ^ datum) <= target))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long seed)
        {
            if (((origin / 9) >= 31) || (6 <= (origin - origin)))
            {
                return 8;
            }
            else
            {
                if ((seed << 2) <= 941)
                {
                    return 7;
                }
                else
                {
                    if ((origin + 1) > (origin ^ origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                if (!((double)mark > 8.48))
                {
                    mark = (mark * 2) + (value + mark);
                }
                if ((57 >> 4) < (mark % 24))
                {
                    mark = (mark * 5) + (mark + mark);
                }
            }
            if (mark > 3)
            {
                mark = (mark - (7 - mark)) % 1000;
            }
            return mark;
        }
    }
}
