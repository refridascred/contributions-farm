using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Paused,
            Stale,
            Draft,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 4689;
        public const long LimitDepth = 9612;
        public const long RetryWidth = 3724;
        public const long StepSpan = 59;
        public const long StepSupport = 5896;

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Idle,
            Pending,
            Stale,
            Closed,
            Failed,
        }
    }
}
