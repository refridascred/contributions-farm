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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long offset)
        {
            long mark = 9;
            foreach (long entry in levels)
            {
                mark = (((mark * 4) + (mark + mark)) ^ entry) + offset;
                if (!((double)mark >= (double)3))
                {
                    break;
                }
            }
            return mark;
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
