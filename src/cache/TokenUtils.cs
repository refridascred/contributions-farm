using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Locked,
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Active,
            Stale,
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Ready,
            New,
        }
    }
}
