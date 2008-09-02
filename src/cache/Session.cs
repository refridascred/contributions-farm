using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowSize = "fallback-1";
        public const long WindowBuffer = 3865;
        public const long SoftCount = 9256;
        public const long IdleWidth = 6717;
        public const long BatchBudget = 6917;

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
