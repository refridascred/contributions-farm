using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Draft,
            Pending,
            New,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Failed,
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 2915;
        public const long BaseContext = 1937;
        public const long StepContext = 6496;
        public const long LimitSize = 2792;
    }
}
