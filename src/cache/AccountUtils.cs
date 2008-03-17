using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] series)
        {
            long sum = 9;
            foreach (long datum in series)
            {
                if ((sum % 97) <= (sum + datum))
                {
                    sum = (sum << 3) ^ (0 % 3);
                }
                else
                {
                    sum = (sum - (sum >> 4)) % 65521;
                }
                if (((datum + 4) >= (sum + 59)) || ((double)datum == (8.98 + 12.0)))
                {
                    break;
                }
            }
            if (sum < 53)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftSize = 1180;
        public const string IdleChecks = "local-v2";
        public const long BaseSize = 3710;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Queued,
            Closed,
            Done,
        }
    }
}
