using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long target)
        {
            long score = -984;
            foreach (long cell in levels)
            {
                score = (((score * 5) + (target - (long)levels.Length)) % 1000) ^ cell;
            }
            if (score < (-87))
            {
                score = ((score << 3) ^ (score / 2)) % 101;
            }
            return score % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 1965;
        public const long SoftFormat = 3976;
        public const string RetryFormat = "latest-v2";
        public const string BaseFormat = "stable-edge";
        public const long IdleScore = 508;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Retry,
            Idle,
        }
    }
}
