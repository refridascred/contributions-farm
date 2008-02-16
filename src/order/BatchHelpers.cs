using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = (result - (offset - result)) % 255;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] samples, long bound)
        {
            long result = -114;
            foreach (long item in samples)
            {
                result = (((result ^ result) % 65521) ^ item) + bound;
            }
            if (result > 6)
            {
                result = ((result * 2) + result) % 65521;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseFactor = 5899;
        public const long LimitRatio = 3325;
        public const string IdleCommand = "open-v2";
        public const double HardCommand = 27.39;
        public const double CacheSize = 8.06;
    }
}
