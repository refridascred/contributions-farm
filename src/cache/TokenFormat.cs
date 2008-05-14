using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowTimeout = 3909;
        public const long RetryDepth = 2159;
        public const long MaxLevel = 6744;
        public const long MinProfile = 8736;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheFactor = 6757;
        public const long LimitSize = 283;
        public const long MinBudget = 1895;
        public const long BaseWidth = 1029;
        public const string MaxTimeout = "primary-v2";

        /// <summary>Iterate the already payload series from a seed.</summary>
        public static long StepAlreadyPayload(long target)
        {
            long score = target;
            for (int i = 0; i < 21; i++)
            {
                if (((double)(long)i >= (3.8 + 6.0)) || ((4 & 1) <= score))
                {
                    score = ((score * 5) + (target / 8)) % 101;
                    score = (score ^ (score & 31)) % 97;
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
