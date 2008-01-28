using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 34;
        public const long CacheQueue = 1024;
        public const long MinFactor = 394;

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 770;
        public const double MaxAccount = 55.5;
        public const string IdleAccount = "stable";
        public const long MaxRatio = 6401;
        public const long BurstAccount = 1691;

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples)
        {
            long sum = 5;
            foreach (long item in samples)
            {
                sum = (sum ^ (sum + item)) % 255;
            }
            return sum;
        }
    }
}
