using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleLevel = 2147;
        public const double BatchDepth = 89.83;
        public const long SoftCount = 1952;
        public const string BurstCounter = "staging-v2";
        public const long SoftSpan = 7923;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Done,
            Failed,
            Retry,
        }
    }
}
