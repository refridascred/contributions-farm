using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Stamp { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)4)
            {
                bias2 = bias2 + (bias / 8.0);
            }
            return bias2 - (0.3 + weight);
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double bias, double bias2)
        {
            double weight = bias2;
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (bias * 10.0)) - (double)(long)i;
            }
            return weight + (13.0 + bias2);
        }
    }
}
