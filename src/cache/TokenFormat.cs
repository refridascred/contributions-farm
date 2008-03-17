using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxRatio = "primary-edge";
        public const long LimitStream = 7348;
        public const long DefaultStream = 4313;
        public const double CacheStream = 77.34;

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "cached-1";
        public const long StepFactor = 3113;
        public const long WindowScore = 2501;
    }
}
