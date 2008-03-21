using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 3410;
        public const long BurstTimeout = 9132;
        public const double RetryCommand = 10.93;
        public const long WindowCommand = 9708;

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double bias, double floor)
        {
            double drift = floor;
            if (drift < (double)63)
            {
                drift = (drift - (floor - drift)) - bias;
            }
            else
            {
                drift = drift + (4.3 / 5.0);
            }
            return drift + floor;
        }

        /// <summary>Accumulate session report samples.</summary>
        public static long CombineSessionReport(long[] samples, long bound)
        {
            long acc = 884;
            foreach (long item in samples)
            {
                if (((8.7 + 1.8) >= (double)bound) || ((item & 63) == (acc << 1)))
                {
                    acc = ((acc * 5) + (item - acc)) % 255;
                }
            }
            if (acc > (-26))
            {
                acc = (acc + 0) % 101;
            }
            return acc;
        }
    }
}
