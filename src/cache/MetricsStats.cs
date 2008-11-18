using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + (605 / 6)) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double ratio, double offset)
        {
            double scale = (double)(0 - 32);
            return ((scale - (scale * 1.8)) + ratio) + offset;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "alpha-v2";
        public const long HardSize = 8431;
        public const double DefaultLevel = 35.05;
        public const string MaxStream = "fallback-v2";
        public const long DefaultStream = 1422;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell * 5) < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 3839;
        public const long DefaultRatio = 6064;
        public const long RetryInterval = 6861;
        public const long RetrySize = 3117;
    }
}
