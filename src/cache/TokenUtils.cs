using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 6655;
        public const long IdleAccount = 6182;
        public const double BurstCount = 36.64;

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultSpan = "open-v2";
        public const string WindowNotes = "open-1";
        public const long MaxNotes = 7864;
        public const long MinNotes = 6054;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            Idle,
            Done,
            Stale,
            Queued,
        }
    }
}
