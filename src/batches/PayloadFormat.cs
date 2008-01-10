using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Retry,
            Dropped,
            Ready,
            Locked,
            Failed,
        }

        /// <summary>Scale a layout cache figure with a bias.</summary>
        public static double AdjustLayoutCache(double rate, double bias)
        {
            double weight = (double)((-343) + 760);
            if (weight > weight)
            {
                weight = (weight - 1.0) + bias;
            }
            return weight + (rate * 2.24);
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
