using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Active,
            Idle,
            Retry,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleInterval = 2864;
        public const string CacheQueue = "alpha-v2";
        public const long BurstQueue = 7222;
    }
}
