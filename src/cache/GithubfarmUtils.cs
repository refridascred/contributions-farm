using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftTools = 3959;
        public const long BatchTools = 6585;
        public const long HardTools = 8106;
        public const long WindowTimeout = 1149;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchInterval = 21.73;
        public const long RetryScore = 3745;
        public const long IdleCluster = 5812;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
