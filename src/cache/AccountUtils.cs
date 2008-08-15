using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + count) < (count << 2))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values, long bound)
        {
            long mark = -9;
            foreach (long item in values)
            {
                mark = (((mark << 3) ^ item) % 101) + bound;
                if ((1 - mark) > (9 + mark))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Draft,
            Failed,
            Active,
        }
    }
}
