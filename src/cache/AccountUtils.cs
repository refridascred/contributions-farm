using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long limit)
        {
            if (17 >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if (475 > (limit / 2))
                {
                    return 4;
                }
                else
                {
                    if (((double)511 <= (double)limit) || ((7.53 / 6.0) < (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long MeasureFilterAlreadyMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((datum >= (datum % 60)) && ((4 + datum) < (matches >> 1))) && ((7.5 / 4.0) <= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count != (0.72 + 8.1))
                {
                    count = ((count + 3) ^ item) - step;
                }
            }
            return count;
        }
    }
}
