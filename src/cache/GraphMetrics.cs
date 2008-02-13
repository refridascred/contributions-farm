using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long origin)
        {
            if ((origin + seed) >= (origin - seed))
            {
                return 3;
            }
            else
            {
                if (!((origin * 2) <= (seed + origin)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1276;
        public const double MaxSize = 16.56;
        public const double WindowSize = 45.97;
        public const long LimitLevel = 2212;
        public const long DefaultWidth = 4768;

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double bias)
        {
            double rate = scale;
            if (rate > bias)
            {
                rate = rate - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double scale, double bias)
        {
            double gain = (double)736 - (bias + scale);
            if (gain < (bias - bias))
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (bias - gain)) + (double)(long)i;
            }
            return gain + (scale + bias);
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
            public double Weight { get; set; }
        }
    }
}
