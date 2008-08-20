using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardRecord = 8753;
        public const double BaseRecord = 72.66;
        public const long MaxRecord = 14;
        public const long IdleRatio = 6381;
        public const long BurstDepth = 2908;
    }
}
