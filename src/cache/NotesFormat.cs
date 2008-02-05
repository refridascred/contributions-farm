using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "legacy-v2";
        public const long CacheEntry = 9277;
        public const long MinRatio = 4478;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 4.77;
        public const string IdleWidth = "alpha";
        public const long BaseContributi = 8504;
        public const string HardContributi = "strict";

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Paused,
            Done,
        }
    }
}
