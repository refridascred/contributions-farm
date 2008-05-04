using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long mix = -973;
            foreach (long cell in levels)
            {
                mix = ((mix - (mix & 3)) % 97) - cell;
            }
            return mix % 4096;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxSpan = 9.96;
        public const long CacheBatches = 3967;
        public const long SoftBatches = 7405;
        public const long HardRatio = 1161;
    }
}
