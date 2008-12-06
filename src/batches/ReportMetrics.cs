using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 5269;
        public const long MinCluster = 4110;
        public const long WindowSpan = 5190;

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 2178;
        public const long HardInterval = 9724;
        public const string BaseRatio = "legacy-1";
        public const long SoftCount = 51;
        public const double StepMetric = 18.99;
    }
}
