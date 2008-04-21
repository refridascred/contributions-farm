using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double scale, double bias)
        {
            double weight = 5.45;
            if (weight > 3.18)
            {
                weight = weight + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (weight + bias)) + (double)(long)i;
            }
            return weight - (17.0 / 9.0);
        }

        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long MeasureBatchFilterMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((matches & 7) <= (entry + matches)) || ((matches & 127) >= (entry << 2)))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 46.93;
        public const long WindowFarm = 8607;
        public const long CacheFarm = 6094;
        public const long RetryFarm = 9581;
    }
}
