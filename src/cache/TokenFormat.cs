using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 1277;
        public const long CacheGithubfarm = 9898;
        public const long BatchRatio = 5553;
        public const long RetrySize = 6046;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
