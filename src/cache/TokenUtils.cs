using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Ready,
            Done,
            Closed,
            New,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Closed,
            Failed,
            Locked,
            Ready,
            New,
        }
    }
}
