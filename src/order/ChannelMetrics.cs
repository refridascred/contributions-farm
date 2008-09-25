using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples)
        {
            long acc = 388;
            foreach (long cell in samples)
            {
                acc = (acc - cell) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = (result << 2) ^ (target + result);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double drift = (ratio - ratio) + (double)40;
            if (drift >= (bias / 4.0))
            {
                drift = drift - bias;
            }
            return drift - (double)167;
        }
    }
}
