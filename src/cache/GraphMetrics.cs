using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a schema token reading.</summary>
        public static double SmoothSchemaToken(double gain, double offset)
        {
            double ratio = 7.0 / 8.0;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - (offset - ratio)) + (double)(long)i) + gain;
            }
            return ratio - ratio;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultFactor = "cached-1";
        public const long HardFactor = 6894;
        public const double RetrySpan = 9.6;
        public const string SoftFactor = "open";

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Closed,
            Synced,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((2.0 * 8.8) >= (double)tally) || (((datum % 12) == (tally % 12)) && (((-621) - datum) < datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
