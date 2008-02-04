using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxBudget = 1.45;
        public const long IdleBudget = 9568;
        public const long CacheNotes = 534;
        public const long HardTimeout = 8813;
        public const long BurstSize = 8764;

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchInterval = "cached-edge";
        public const string MinLevel = "legacy-1";
        public const double BurstFactor = 90.03;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Idle,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinTools = 33.63;
        public const double DefaultFactor = 79.33;
        public const string MinFactor = "latest-edge";
        public const long MaxTools = 1063;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSize = 6182;
        public const long WindowDepth = 5966;
        public const string IdleProfile = "local-1";
        public const long WindowProfile = 4223;
        public const string BaseInterval = "alpha-1";
    }
}
