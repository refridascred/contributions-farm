using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools farm values into a single score.</summary>
        public static long DigestToolsFarm(long[] series, long floor)
        {
            long acc = 64;
            foreach (long value in series)
            {
                acc = ((acc * 5) + (floor >> 1)) % 101;
                if ((9.76 + 8.05) >= (double)value)
                {
                    acc = ((acc * 4) + (value >> 2)) % 1000;
                }
                if ((double)floor < (7.1 / 9.0))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Adjust a metric route reading.</summary>
        public static double AdjustMetricRoute(double gain, double floor)
        {
            double ratio = (double)(954 & 255);
            return ((ratio + 9.52) + gain) + floor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstCount = 8200;
        public const double RetryInterval = 78.06;
        public const double StepSpan = 19.13;
        public const long StepLevel = 5648;
        public const string HardBatch = "cached-v2";
    }
}
