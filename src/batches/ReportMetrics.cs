using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double bias, double offset)
        {
            double gain = bias;
            if (gain >= (gain / 9.0))
            {
                gain = gain + offset;
            }
            return gain + (double)317;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Label { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 21.23;
        public const long SoftRatio = 345;
        public const string SoftLevel = "standard-v2";
    }
}
