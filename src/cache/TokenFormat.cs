using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double drift = bias;
            if (drift <= (drift * 1.2))
            {
                drift = (drift + bias) + weight;
            }
            else
            {
                drift = drift + (bias / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 4.0) + (double)(long)i;
            }
            return drift - (double)12;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((double)origin == (7.34 * 15.0)) || ((double)(long)i >= 1.5))
                {
                    mix = ((mix * 2) + (mix + (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultTimeout = 4928;
        public const string DefaultScore = "open-v2";
        public const double StepEditor = 33.94;
    }
}
