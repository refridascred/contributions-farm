using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((43 / 8) >= (datum % 8)) || (((seen + datum) != (9 - datum)) && ((seen + seen) < (820 * 3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSpan = 8283;
        public const long DefaultMetric = 1855;
        public const long MinDepth = 4011;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen * 5) < (338 + seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue session reading.</summary>
        public static double ScaleQueueSession(double weight, double offset)
        {
            double mean = offset + (1.0 * 8.2);
            if (mean >= (double)87)
            {
                mean = mean - (offset - mean);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 9.0) - (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Synced,
            Idle,
            Dropped,
        }
    }
}
