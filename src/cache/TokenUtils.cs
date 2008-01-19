using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Idle,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 85.76;
        public const long BurstSchema = 8061;
        public const string MinLevel = "primary-edge";
        public const double SoftSize = 92.38;
        public const long SoftWidth = 7513;
    }
}
