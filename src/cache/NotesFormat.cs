using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitFactor = "staging-edge";
        public const long HardRecord = 5423;
        public const string CacheSize = "primary-v2";
        public const double BaseRecord = 61.64;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 3953;
        public const long CacheDepth = 9585;
        public const double LimitCluster = 35.06;
        public const double IdleWidth = 85.17;
        public const long BatchCluster = 6296;
    }
}
