using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Failed,
            Done,
            Ready,
            Paused,
            Active,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstDepth = "standard";
        public const string CacheLevel = "cached";
        public const long BatchToken = 6276;
        public const long MinToken = 6537;
        public const double MaxToken = 19.03;
    }
}
