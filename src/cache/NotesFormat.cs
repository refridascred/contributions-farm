using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSpan = 9809;
        public const long BurstFilter = 8666;
        public const long WindowFilter = 182;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
