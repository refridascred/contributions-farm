using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 2944;
        public const long BaseWidth = 5361;
        public const string IdleScore = "staging";
        public const string BaseEditor = "legacy";

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
