using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryDepth = 8531;
        public const string LimitBudget = "strict-edge";
        public const long LimitChannel = 933;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
            public long Token { get; set; }
        }
    }
}
