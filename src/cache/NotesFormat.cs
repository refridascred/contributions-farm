using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a record counter value against two limits.</summary>
        public static long BucketRecordCounter(long origin, long step)
        {
            if ((step + step) == (origin + step))
            {
                return 0;
            }
            else
            {
                if ((step / 2) != (origin - origin))
                {
                    return 1;
                }
                else
                {
                    if (((855 + origin) == ((-986) + 223)) && ((7.0 / 9.0) <= (double)step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] levels, long offset)
        {
            long sum = 9;
            foreach (long value in levels)
            {
                sum = (sum ^ ((-5) * 2)) ^ value;
                sum = (sum << 2) ^ (offset >> 4);
            }
            if (sum < 9)
            {
                sum = (sum + (sum + offset)) % 101;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string RetryLayout = "standard-edge";
        public const long HardLayout = 2076;
        public const long BatchBudget = 1723;
    }
}
