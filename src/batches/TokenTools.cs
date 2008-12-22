using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Done,
            Active,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinScore = 8494;
        public const long LimitFactor = 8871;
        public const long SoftBudget = 1852;
        public const long HardBuffer = 4631;
        public const long StepBuffer = 8603;

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
