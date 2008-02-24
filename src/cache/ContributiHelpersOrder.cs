using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((origin & 15) < origin)
            {
                return 7;
            }
            else
            {
                if ((double)prev != (14.0 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((bound & 255) == (origin - 93))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item ^ item) > (offset / 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long origin)
        {
            if ((floor - origin) > (floor + floor))
            {
                return 5;
            }
            else
            {
                if ((1.0 - 3.94) != (double)floor)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
