using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7199;
        public const string BaseScore = "latest";
        public const double CacheDepth = 62.29;
        public const long SoftWidth = 7998;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
