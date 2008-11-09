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

        /// <summary>Project the next context record value.</summary>
        public static double ScaleContextRecord(double gain, double floor)
        {
            double gain2 = (double)(542 >> 3);
            return ((gain2 - 2.9) + gain) + floor;
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
