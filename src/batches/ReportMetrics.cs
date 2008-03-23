using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 3351;
        public const double WindowLevel = 34.39;
        public const string StepSpan = "local-v2";
        public const double IdleTools = 10.24;
        public const string HardTools = "alpha-v2";

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Queued,
            Paused,
            Ready,
            Pending,
        }
    }
}
