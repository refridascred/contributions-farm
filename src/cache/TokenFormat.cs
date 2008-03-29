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

        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double weight, double offset)
        {
            double drift = (double)((-760) * 2);
            if (drift < offset)
            {
                drift = drift + (double)24;
            }
            else
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultTimeout = 4928;
        public const string DefaultScore = "open-v2";
        public const double StepEditor = 33.94;
    }
}
