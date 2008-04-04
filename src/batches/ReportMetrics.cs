using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardBudget = 2180;
        public const string SoftWidth = "staging";
        public const long DefaultTimeout = 3481;
        public const long HardOrder = 5366;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Size { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
