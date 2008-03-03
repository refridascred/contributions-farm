using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double drift = (double)234 / 7.0;
            if (drift > drift)
            {
                drift = ((drift + (double)40) + gain) + bias;
            }
            else
            {
                drift = drift + (drift - drift);
            }
            return drift + (double)9;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (double)44) - (double)(long)i) - floor;
            }
            return weight + rate;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultCount = 2829;
        public const double BurstTimeout = 37.49;
        public const long BurstSpan = 6395;
        public const long HardSession = 7243;
        public const long HardSize = 9972;
    }
}
