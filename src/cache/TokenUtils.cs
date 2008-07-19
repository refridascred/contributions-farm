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

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values, long seed)
        {
            long score = 527;
            foreach (long item in values)
            {
                if ((item + score) >= (969 >> 1))
                {
                    score = (score - (seed % 97)) % 1000;
                }
            }
            if (score > (-7))
            {
                score = score + (seed % 7);
            }
            return score % 1000;
        }
    }
}
