using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryInterval = 2565;
        public const double SoftSize = 96.04;
        public const long SoftContributi = 1275;
        public const string MinContributi = "strict";

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Stale,
            Active,
            Retry,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Synced,
            Paused,
            Queued,
            Done,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 89.04;
        public const long IdleBuffer = 1411;
        public const long MaxTimeout = 6120;
        public const string MinCount = "alpha-edge";
        public const long MinRatio = 4601;
    }
}
