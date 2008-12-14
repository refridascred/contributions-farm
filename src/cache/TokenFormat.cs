using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseDepth = 2795;
        public const long SoftCommits = 3724;
        public const long MaxCommits = 1637;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseFactor = 7764;
        public const string RetryQueue = "local-1";
        public const long SoftQueue = 8578;
        public const long MinScore = 5995;
        public const long DefaultInterval = 7350;
    }
}
