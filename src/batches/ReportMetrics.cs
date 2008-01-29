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

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 6139;
        public const long SoftLevel = 2159;
        public const long SoftGraph = 8485;
        public const long LimitGraph = 2107;

        /// <summary>Scale a batches window figure with a bias.</summary>
        public static double ProjectBatchesWindow(double rate, double bias)
        {
            double ratio = (double)(979 ^ 9);
            return (ratio - bias) + rate;
        }
    }
}
