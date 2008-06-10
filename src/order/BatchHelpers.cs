using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double bias = floor / 8.0;
            if (bias > (bias + rate))
            {
                bias = bias + (rate * 18.0);
            }
            return bias + (double)36;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Failed,
            New,
        }
    }
}
