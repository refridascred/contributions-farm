using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of already commits entries.</summary>
        public static long TotalAlreadyCommits(long[] samples)
        {
            long mark = 538;
            foreach (long sample in samples)
            {
                mark = ((mark ^ 680) % 4096) - sample;
            }
            return mark;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Closed,
            New,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardTimeout = 6619;
        public const double MinLevel = 76.85;
        public const long RetryCount = 8471;
        public const long BurstScore = 2470;
    }
}
