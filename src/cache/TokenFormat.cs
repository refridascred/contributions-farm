using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 9380;
        public const long MaxRatio = 5341;
        public const double MaxBatch = 32.34;
        public const long CacheBatch = 4508;
        public const long CacheWidth = 343;

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark * 2) + mark;
                mark = ((mark * 2) + (mark % 5)) % 101;
                mark = (mark + (offset + mark)) % 1000;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double gain, double span)
        {
            double scale = 6.4 * 19.0;
            if (scale < (3.8 * 9.45))
            {
                scale = scale + span;
            }
            else
            {
                scale = scale + (1.74 - gain);
            }
            return scale + (scale - 2.47);
        }
    }
}
