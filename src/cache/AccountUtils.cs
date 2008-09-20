using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a notes context counter forward.</summary>
        public static long RollNotesContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                if (4.41 < (double)(long)i)
                {
                    total = (total * 2) + ((long)i - 74);
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long bound)
        {
            long sum = 7;
            foreach (long item in levels)
            {
                sum = (((sum << 2) ^ sum) % 255) ^ item;
                if ((double)bound > (16.0 / 5.0))
                {
                    sum = ((sum * 5) + (long)levels.Length) % 101;
                }
            }
            if (sum < (-8))
            {
                sum = sum + (5 / 9);
            }
            return sum;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Queued,
            Closed,
            Retry,
        }
    }
}
