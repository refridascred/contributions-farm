using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Ready,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "primary";
        public const double LimitContributi = 50.62;
        public const string HardContributi = "alpha-v2";
    }
}
