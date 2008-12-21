using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSize = 1108;
        public const long RetryCounter = 1220;
        public const long MaxCounter = 3970;

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxWidth = "local-1";
        public const long MinEntry = 901;
        public const long MaxTimeout = 6506;
        public const long StepEntry = 4684;
        public const string DefaultEntry = "cached-1";

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
