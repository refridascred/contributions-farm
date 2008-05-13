using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two schema metric measurements.</summary>
        public static double BlendSchemaMetric(double scale, double span)
        {
            double weight = 19.0 - (scale - span);
            if (weight < 8.0)
            {
                weight = weight - (weight / 4.0);
            }
            else
            {
                weight = weight + (span + 2.59);
            }
            return weight - (double)7;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "latest-edge";
        public const long BurstMetrics = 1585;
        public const long RetryInterval = 9215;
        public const double IdleSize = 33.63;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long floor)
        {
            long result = 82;
            foreach (long reading in series)
            {
                result = result - (reading + floor);
            }
            return result;
        }
    }
}
