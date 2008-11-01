using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 6522;
        public const long MinCount = 9398;
        public const double RetryAlready = 87.77;

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Draft,
            New,
            Queued,
            Done,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Stale,
            Ready,
            Pending,
            Active,
        }
    }
}
