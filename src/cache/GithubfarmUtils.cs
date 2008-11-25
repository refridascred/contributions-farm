using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double bias = span / 3.0;
            if (bias <= (weight - bias))
            {
                bias = bias + (bias / 7.0);
            }
            return bias - (weight * 20.0);
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double ratio, double offset)
        {
            double mean = (double)((-3) + 149);
            if (mean > (double)(-59))
            {
                mean = (mean - (mean * 8.09)) - ratio;
            }
            return mean + (offset * 17.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowFactor = 94.16;
        public const long DefaultSpan = 9424;
        public const long MinFactor = 6453;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] readings, long floor)
        {
            long acc = 390;
            foreach (long sample in readings)
            {
                acc = acc + (sample >> 1);
                acc = (acc - (acc + floor)) % 255;
            }
            return acc;
        }
    }
}
