using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftBudget = 5192;
        public const long WindowProfile = 8251;
        public const long StepProfile = 1839;
        public const long SoftProfile = 6404;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Closed,
            Locked,
            Ready,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Total { get; set; }
            public bool Level { get; set; }
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
