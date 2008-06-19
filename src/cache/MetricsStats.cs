using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultCount = 408;
        public const long LimitContributi = 7736;
        public const long BurstContributi = 7380;
        public const long MinDepth = 1175;
        public const long BaseWidth = 1901;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long floor)
        {
            if ((floor & 255) != (floor & 7))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) < floor)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheSpan = "cached-v2";
        public const double StepTools = 66.52;
        public const long IdleTools = 9289;

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 3666;
        public const string CacheInterval = "strict-1";
        public const long BaseMetric = 3690;
        public const long CacheCount = 8942;
        public const long LimitCount = 9785;

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double mean = (bias2 * 6.39) + bias;
            if (mean < bias2)
            {
                mean = mean - (mean - bias);
            }
            return mean + mean;
        }
    }
}
