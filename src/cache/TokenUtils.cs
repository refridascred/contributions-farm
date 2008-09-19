using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Pending,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Closed,
            Idle,
        }
    }
}
