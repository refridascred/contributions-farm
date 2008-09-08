using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Locked,
            Active,
            Failed,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleInterval = 17.36;
        public const double BaseInterval = 14.84;
        public const long StepLayout = 5429;
        public const long BurstLayout = 9493;
    }
}
