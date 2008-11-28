using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Done,
            Paused,
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
