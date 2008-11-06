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

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                carry = ((carry ^ (carry % 97)) % 4096) - value;
            }
            return carry % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryCount = "legacy-1";
        public const long WindowGraph = 5285;
        public const string MaxGraph = "strict-v2";
    }
}
