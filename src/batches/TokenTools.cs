using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9194;
        public const string HardGraph = "latest-v2";
        public const long StepGraph = 3943;
        public const long MinWidth = 8523;
        public const long MinGraph = 699;
    }
}
