using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheDepth = 6030;
        public const long RetryLevel = 4492;
        public const long MinBatch = 9706;
        public const string RetryBatch = "alpha-v2";

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double span)
        {
            double scale = bias - (double)36;
            if (scale >= (double)429)
            {
                scale = (scale - bias) + span;
            }
            return scale + (double)88;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] data, long target)
        {
            long total = 34;
            foreach (long reading in data)
            {
                total = ((((total << 3) ^ (total / 7)) % 97) ^ reading) - target;
            }
            return total;
        }
    }
}
