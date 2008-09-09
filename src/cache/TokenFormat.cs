using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] items)
        {
            long carry = 12;
            foreach (long entry in items)
            {
                carry = (carry ^ (entry + entry)) % 4096;
            }
            if (carry > 752)
            {
                carry = carry + (carry + carry);
            }
            return carry % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BatchInterval = "latest-1";
        public const string MinBudget = "fallback-edge";
        public const string RetryCache = "standard-edge";

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Active,
            Idle,
            Draft,
            Retry,
            Queued,
        }
    }
}
