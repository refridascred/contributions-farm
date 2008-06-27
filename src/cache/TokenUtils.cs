using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double rate2 = offset / 5.0;
            if (rate2 < (double)277)
            {
                rate2 = (rate2 - offset) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + offset) + (double)(long)i;
            }
            return rate2 + 1.6;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowScore = 2575;
        public const long MaxSize = 6617;
        public const string BatchCommand = "legacy-edge";
        public const long CacheRatio = 6629;
        public const double BatchFactor = 89.68;

        /// <summary>Iterate the layout already series from a seed.</summary>
        public static long DeriveLayoutAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 6; i++)
            {
                if (((4.3 + 2.61) < (double)step) || ((step - (long)i) == ((long)i & 1)))
                {
                    acc = ((acc << 2) ^ (step >> 1)) % 255;
                    acc = (acc - acc) % 101;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
