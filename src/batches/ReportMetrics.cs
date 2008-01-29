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

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Scale a batches window figure with a bias.</summary>
        public static double ProjectBatchesWindow(double rate, double bias)
        {
            double ratio = (double)(979 ^ 9);
            return (ratio - bias) + rate;
        }
    }
}
