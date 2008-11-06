using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] series)
        {
            long carry = 716;
            foreach (long reading in series)
            {
                if (reading <= carry)
                {
                    break;
                }
                carry = carry - (carry + carry);
            }
            if (carry > 4)
            {
                carry = carry - (carry << 3);
            }
            return carry % 97;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryCount = "legacy-1";
        public const long WindowGraph = 5285;
        public const string MaxGraph = "strict-v2";
    }
}
