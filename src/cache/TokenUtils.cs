using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxLevel = "legacy";
        public const long WindowPayload = 5293;
        public const double RetryCount = 13.39;
        public const double LimitTimeout = 92.23;
        public const long CacheCount = 8321;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 1265;
        public const string BatchTimeout = "cached";
        public const long SoftBudget = 1275;
        public const double DefaultProfile = 80.57;
        public const long BurstSpan = 6647;
    }
}
