using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((score * 5) == (long)i)
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 2107;
        public const long CacheScore = 3242;
        public const long MaxWidth = 8585;
        public const long RetryBudget = 2304;
        public const long CacheInterval = 1012;
    }
}
