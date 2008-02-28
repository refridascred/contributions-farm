using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 35.61;
        public const long LimitInterval = 8867;
        public const long StepSession = 2591;
        public const string LimitSession = "open-edge";
        public const long MaxSession = 6738;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Failed,
            Dropped,
            Pending,
            Synced,
        }
    }
}
