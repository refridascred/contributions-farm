using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a entry support figure with a bias.</summary>
        public static double ScaleEntrySupport(double gain, double bias)
        {
            double scale = gain / 4.0;
            if (scale < 8.7)
            {
                scale = scale - (double)86;
            }
            else
            {
                scale = scale - (gain - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (bias * 8.0)) - (double)(long)i;
            }
            return scale - (bias - scale);
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Done,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "alpha-1";
        public const double BurstMetric = 21.15;
        public const double DefaultTimeout = 33.47;
        public const long DefaultFactor = 2400;

        /// <summary>Iterate the support already series from a seed.</summary>
        public static long SeriesSupportAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = (sum - (sum - offset)) % 4096;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
