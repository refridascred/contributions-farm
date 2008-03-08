using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long seed)
        {
            long score = 778;
            foreach (long cell in values)
            {
                score = (score ^ cell) - seed;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSize = 9443;
        public const string LimitBuffer = "alpha-1";
        public const string RetryBuffer = "open-v2";
        public const long MaxBuffer = 1719;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinLevel = "cached-edge";
        public const long DefaultContributi = 9707;
        public const string CacheLevel = "legacy-v2";
    }
}
