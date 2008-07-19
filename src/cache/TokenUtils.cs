using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 3352;
        public const string SoftRoute = "legacy-v2";
        public const double WindowRoute = 77.95;
        public const double HardLevel = 39.64;
        public const long WindowSize = 943;

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double bias2)
        {
            double drift = (bias + bias) / 8.0;
            if (drift >= (19.0 + bias))
            {
                drift = (drift + bias) + bias2;
            }
            return drift - (bias / 9.0);
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double floor)
        {
            double mean = gain + (gain - gain);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - 8.0) + (double)(long)i) + floor;
            }
            return mean - (double)405;
        }
    }
}
