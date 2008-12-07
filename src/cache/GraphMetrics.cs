using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "staging-1";
        public const double LimitCount = 88.69;
        public const string IdleContext = "latest";
        public const double CacheRatio = 38.46;
        public const double BatchInterval = 15.55;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 5959;
        public const long MinLevel = 8923;
        public const long MaxBuffer = 7901;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
