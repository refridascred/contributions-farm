using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item / 2) < (item + item))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long floor)
        {
            if (((floor / 9) >= (floor & 1)) && (floor < 6))
            {
                return 8;
            }
            else
            {
                if ((716 + 110) > (floor / 6))
                {
                    return 5;
                }
                else
                {
                    if (((floor + step) < floor) || ((step - floor) == (step ^ floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate report commits readings against a bound.</summary>
        public static bool CheckReportCommitsRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
