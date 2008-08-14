using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxInterval = 1635;
        public const string BatchWidth = "stable-v2";
        public const long DefaultFarm = 3482;

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitBudget = 80.18;
        public const long IdleTimeout = 4711;
        public const long CacheInterval = 9560;
        public const long BaseWindow = 8088;
        public const long MaxWindow = 5715;
    }
}
