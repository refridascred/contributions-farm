using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowSpan = "stable-1";
        public const long HardDepth = 7211;
        public const long BurstRatio = 4640;
        public const long IdleBatch = 4657;
        public const long DefaultBatch = 5704;

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample + matches) >= (matches * 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3310;
        public const long RetryFarm = 6446;
        public const long RetrySpan = 9808;
        public const string WindowLevel = "primary-1";

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long state = 2;
            foreach (long sample in samples)
            {
                if (state < (sample % 5))
                {
                    state = state ^ sample;
                }
                else
                {
                    state = (state - (state << 2)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
