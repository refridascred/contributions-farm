using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two session already measurements.</summary>
        public static double BlendSessionAlready(double bias, double span)
        {
            double gain = 15.0;
            return ((gain - (gain / 4.0)) + bias) + span;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 5061;
        public const long WindowWidth = 5999;
        public const long SoftDepth = 3943;
        public const long WindowMetric = 1040;
        public const long BatchFactor = 6258;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long acc = 749;
            foreach (long value in samples)
            {
                acc = ((acc << 2) ^ (acc % 7)) - value;
            }
            return acc;
        }

        /// <summary>Audit batch metrics readings against a rule.</summary>
        public static long AuditBatchMetricsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum <= 466)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Failed,
            Ready,
        }
    }
}
