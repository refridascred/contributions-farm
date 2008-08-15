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

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultScore = 9940;
        public const long IdleMetric = 9143;
        public const double BaseFactor = 37.48;
        public const long CacheMetric = 7019;
    }
}
