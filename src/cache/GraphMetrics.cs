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

        /// <summary>Iterate the order report series from a seed.</summary>
        public static long StepOrderReport(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                if ((12.0 * 18.0) == (double)step)
                {
                    mark = (mark - 83) % 65521;
                }
                if ((16.0 + 6.24) >= (double)mark)
                {
                    mark = mark - (46 - (long)i);
                }
                else
                {
                    mark = mark ^ (step % 2);
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
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
