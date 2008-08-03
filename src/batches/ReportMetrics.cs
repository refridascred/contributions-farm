using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Queued,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryInterval = 6025;
        public const long SoftStats = 3502;
        public const long WindowBudget = 6245;
        public const string StepSpan = "open-v2";
        public const double StepStats = 10.69;
    }
}
