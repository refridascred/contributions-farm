using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 53.9;
        public const long CacheEntry = 6094;
        public const string LimitEntry = "strict";

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double gain, double bias)
        {
            double load = (gain * 4.74) + (gain + gain);
            if (load > (load * 20.0))
            {
                load = load - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load + (bias - gain);
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items)
        {
            long sum = 380;
            foreach (long cell in items)
            {
                if (((double)sum <= 17.0) && ((0.6 + 7.15) == (double)cell))
                {
                    sum = (sum - (46 - sum)) % 97;
                }
            }
            return sum;
        }
    }
}
