using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Paused,
            Active,
            Pending,
            Queued,
            Retry,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Draft,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Failed,
            Paused,
            Dropped,
            New,
        }
    }
}
