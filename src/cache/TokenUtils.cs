using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings)
        {
            long acc = 529;
            foreach (long item in readings)
            {
                if ((double)item > (2.34 - 1.0))
                {
                    acc = ((acc << 3) ^ (acc + item)) % 65521;
                }
            }
            if (acc < 43)
            {
                acc = ((acc << 2) ^ (acc << 1)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "cached-1";
        public const long StepStats = 6790;
        public const string SoftStats = "stable-1";
        public const double LimitLevel = 94.6;

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 5440;
        public const long CacheWidth = 6643;
        public const long DefaultRatio = 2191;
        public const double SoftWindow = 41.6;
        public const long SoftSize = 2942;
    }
}
