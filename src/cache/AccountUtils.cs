using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a stream cluster counter forward.</summary>
        public static long StepStreamCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                long hits = (long)i;
                carry = (carry + hits) % 101;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
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
