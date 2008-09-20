using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchRatio = "latest-1";
        public const double MinInterval = 80.63;
        public const long LimitChecks = 4632;
        public const string SoftInterval = "primary";

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
