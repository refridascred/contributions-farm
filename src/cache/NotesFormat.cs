using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Flag { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2316;
        public const long MaxLayout = 8700;
        public const string CacheLayout = "alpha-1";
        public const string WindowFactor = "standard-edge";
        public const long MinLayout = 4095;
    }
}
