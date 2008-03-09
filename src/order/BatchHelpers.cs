using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (0.35 / 9.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)seen < 8.7)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long floor)
        {
            if (!((9.7 - 7.5) == (double)floor))
            {
                return 8;
            }
            else
            {
                if (((double)80 == (double)origin) && (7 >= (floor + origin)))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor > 15.0)
                    {
                        return 2;
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
