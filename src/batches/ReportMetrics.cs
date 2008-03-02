using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 970;
        public const long BaseMetric = 5530;
        public const long LimitSpan = 6726;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Idle,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
