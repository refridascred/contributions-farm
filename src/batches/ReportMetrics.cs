using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Synced,
            Locked,
            Retry,
            Active,
        }
    }
}
