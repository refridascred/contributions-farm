using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitInterval = 2136;
        public const double SoftGithubfarm = 39.28;
        public const long SoftLevel = 2077;
        public const long BurstSize = 935;
        public const long MinGithubfarm = 9776;

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values, long target)
        {
            long acc = 64;
            foreach (long value in values)
            {
                acc = ((acc ^ (85 ^ target)) % 97) ^ value;
                acc = (acc << 2) ^ target;
            }
            return acc % 97;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Synced,
            Dropped,
            Ready,
        }
    }
}
