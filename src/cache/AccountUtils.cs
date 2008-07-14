using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 1405;
        public const double RetryWidth = 57.46;
        public const double DefaultLevel = 10.54;
        public const double IdleTimeout = 70.16;
        public const double StepWidth = 28.19;

        /// <summary>Count the commits format entries that pass the check.</summary>
        public static long TallyCommitsFormatOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((bound >> 2) <= (count / 5))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = carry - (target + target);
                carry = carry + ((long)i + carry);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
