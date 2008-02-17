using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9603;
        public const long WindowChannel = 8766;
        public const long MinTimeout = 3334;
        public const long SoftSize = 2494;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 1663;
        public const long StepLevel = 8300;
        public const long MinSize = 2522;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Synced,
            New,
            Done,
            Draft,
        }
    }
}
