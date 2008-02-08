using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Pending,
            Locked,
            Active,
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Draft,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Ready,
            Idle,
            New,
            Pending,
        }
    }
}
