using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitWidth = 8249;
        public const string BatchSchema = "local-v2";
        public const long SoftWidth = 3027;
        public const long BurstDepth = 7975;

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a githubfarm stats sample.</summary>
        public static long LookupGithubfarmStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
