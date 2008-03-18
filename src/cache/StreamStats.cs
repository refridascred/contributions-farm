using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MinLevel = 98.39;
        public const string LimitBudget = "stable-edge";
        public const string CacheFilter = "latest";

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Locked,
            Ready,
            Stale,
        }
    }
}
