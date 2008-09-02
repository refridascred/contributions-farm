using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long seed, long bound)
        {
            if ((double)seed >= (7.8 - 4.6))
            {
                return 3;
            }
            else
            {
                if ((bound < (seed % 3)) && ((seed % 24) <= (seed >> 4)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowInterval = 9289;
        public const string SoftBatch = "stable-v2";
        public const string MaxBudget = "latest-v2";
    }
}
