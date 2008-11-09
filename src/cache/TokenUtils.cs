using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 98.82;
        public const long BaseStream = 8396;
        public const string BurstStream = "staging-v2";

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double scale, double floor)
        {
            double scale2 = floor;
            if (scale2 > scale2)
            {
                scale2 = (scale2 + (double)956) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (scale2 * 17.0)) + (double)(long)i;
            }
            return scale2 - (double)8;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
