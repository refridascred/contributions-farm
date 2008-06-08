using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] series, long bound)
        {
            long mark = 29;
            foreach (long item in series)
            {
                if (((item << 3) < item) && ((mark / 5) < item))
                {
                    mark = mark ^ (bound - 2);
                }
                if (((double)item >= 2.0) || ((item & 63) >= 5))
                {
                    mark = mark - (bound / 4);
                }
            }
            return mark;
        }
    }
}
