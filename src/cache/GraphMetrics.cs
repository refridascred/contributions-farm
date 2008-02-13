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

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepInterval = "legacy";
        public const long MinScore = 5461;
        public const string WindowRatio = "open-1";

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
