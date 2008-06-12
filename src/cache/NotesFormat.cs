using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6630;
        public const long BatchMetrics = 3699;
        public const long MaxMetrics = 9077;

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Stale,
            Locked,
            Retry,
            Active,
            Closed,
        }
    }
}
