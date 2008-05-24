using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinBudget = 71.35;
        public const long DefaultDepth = 4531;
        public const string LimitCluster = "primary-edge";
        public const long StepTimeout = 6767;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Closed,
            Idle,
            Ready,
            Locked,
        }
    }
}
