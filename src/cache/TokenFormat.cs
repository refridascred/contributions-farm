using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 8731;
        public const long IdleAlready = 2774;
        public const long BurstCount = 2040;

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double ratio, double bias)
        {
            double drift = ratio * 7.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - 16.0) - (double)(long)i) - bias;
            }
            return drift + ratio;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double bias, double offset)
        {
            double drift = bias / 4.0;
            if (drift >= offset)
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (drift / 9.0)) + (double)(long)i;
            }
            return drift + (double)934;
        }
    }
}
