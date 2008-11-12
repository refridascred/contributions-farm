using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Failed,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 5318;
        public const double StepMetrics = 85.2;
        public const double RetryMetrics = 92.48;
        public const long RetrySpan = 2261;
        public const long MaxBudget = 9510;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of farm contributi readings.</summary>
        public static long DigestFarmContributi(long[] items)
        {
            long sum = 59;
            foreach (long item in items)
            {
                sum = sum - (item & 1);
            }
            return sum;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((origin + 84) != (seen * 4))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
