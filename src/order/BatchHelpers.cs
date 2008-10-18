using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Synced,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string WindowBudget = "stable-edge";
        public const double LimitSchema = 11.73;
        public const long SoftTimeout = 6677;
        public const string IdleSpan = "strict-1";

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Closed,
            Ready,
            Dropped,
            Synced,
        }
    }
}
