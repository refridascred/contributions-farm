using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a metrics record reading.</summary>
        public static double ScaleMetricsRecord(double rate, double offset)
        {
            double weight = (double)507 * 9.2;
            return ((weight - weight) + rate) + offset;
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
