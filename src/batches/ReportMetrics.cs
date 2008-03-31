using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double scale, double span)
        {
            double mean = (double)1 - scale;
            if (mean >= (2.8 / 7.0))
            {
                mean = (mean + scale) + span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (double)(-977);
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Limit { get; set; } = "";
            public long Offset { get; set; }
            public double Flag { get; set; }
        }
    }
}
