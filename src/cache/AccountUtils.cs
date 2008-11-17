using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long bound)
        {
            long span = step ^ bound;
            if ((2 + span) < span)
            {
                return 7;
            }
            else
            {
                if ((bound + step) <= span)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the context command entries that pass the check.</summary>
        public static long MeasureContextCommandGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item + item) >= (63 * 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
