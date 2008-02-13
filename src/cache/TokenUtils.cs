using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftBatches = "stable-v2";
        public const long DefaultSize = 6097;
        public const long CacheBatches = 5999;
        public const long IdleBatches = 1847;

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] data, long floor)
        {
            long score = 261;
            foreach (long sample in data)
            {
                if (((floor + sample) <= (237 - sample)) && ((floor + 0) < (sample + score)))
                {
                    score = ((score * 3) + (sample << 3)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
