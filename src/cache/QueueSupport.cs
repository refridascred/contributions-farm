using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
