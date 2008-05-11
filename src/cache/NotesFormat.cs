using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstScore = 7114;
        public const string BurstNotes = "primary-v2";
        public const long MaxNotes = 1743;
        public const long CacheBudget = 3180;
        public const long StepNotes = 4521;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 6049;
        public const double MaxRatio = 41.04;
        public const long WindowCommand = 7057;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 2420;
        public const long BatchEntry = 8393;
        public const long IdleWidth = 2180;
    }
}
