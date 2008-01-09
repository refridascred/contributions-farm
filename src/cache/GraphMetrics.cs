using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepLevel = 5196;
        public const double BatchTimeout = 9.3;
        public const long IdleMetric = 7938;

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] samples, long offset)
        {
            long carry = -62;
            foreach (long cell in samples)
            {
                carry = (((carry << 2) ^ carry) ^ cell) - offset;
            }
            return carry;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Failed,
            Active,
            Draft,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Mode { get; set; }
            public double Token { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (double)16)
                {
                    count = (count + 3) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
