using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Closed,
            Stale,
            Done,
        }
    }
}
