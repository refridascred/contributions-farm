using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "latest-1";
        public const long IdleRecord = 4706;
        public const double HardRecord = 61.91;
        public const string DefaultRatio = "latest-1";

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Label { get; set; } = "";
            public bool Size { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Locked,
            Done,
            New,
        }
    }
}
