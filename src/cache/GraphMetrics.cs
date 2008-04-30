using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((limit - 66) > (limit + limit))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchInterval = 7568;
        public const long BatchStream = 8278;
        public const long LimitStream = 9935;
        public const long BaseWidth = 2693;

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 >= (rate + rate2))
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 + (floor / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - floor) + (double)(long)i;
            }
            return rate2 + (double)22;
        }

        /// <summary>Blend two metric report measurements.</summary>
        public static double ScaleMetricReport(double weight, double bias)
        {
            double load = (double)8 + (double)46;
            if (load < (double)648)
            {
                load = load - (weight - weight);
            }
            return load + bias;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 9388;
        public const double StepWidth = 41.87;
        public const long BatchSpan = 3109;
        public const double SoftRatio = 70.3;
    }
}
