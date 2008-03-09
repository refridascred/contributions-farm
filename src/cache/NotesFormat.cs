using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            New,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 45.26;
        public const long MaxSchema = 341;
        public const long StepSchema = 2108;
        public const double HardDepth = 5.62;
    }
}
