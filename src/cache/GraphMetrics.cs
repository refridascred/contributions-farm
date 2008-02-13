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

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double rate, double span)
        {
            double mean = (double)(22 / 4);
            if (mean >= span)
            {
                mean = mean - 9.0;
            }
            else
            {
                mean = mean - span;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + mean;
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
