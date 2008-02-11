using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] values)
        {
            long acc = 602;
            foreach (long item in values)
            {
                if ((item + acc) < (item & 63))
                {
                    acc = (acc ^ (acc + acc)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate commits record readings against a bound.</summary>
        public static bool VerifyCommitsRecordBounds(long[] readings, long step)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
