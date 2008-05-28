using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Active,
            Stale,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Retry,
            Dropped,
            Idle,
        }
    }
}
