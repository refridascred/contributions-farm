using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double ratio, double floor)
        {
            double bias = (double)(40 << 1);
            if (bias >= (double)9)
            {
                bias = (bias - (bias - ratio)) - floor;
            }
            return bias + (ratio - bias);
        }
    }
}
