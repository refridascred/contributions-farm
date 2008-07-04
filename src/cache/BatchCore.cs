using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 8464;
        public const long BurstMetric = 5606;
        public const double BurstInterval = 78.78;
        public const string BatchRatio = "strict-edge";

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheInterval = 474;
        public const double BatchScore = 13.8;
        public const double BatchFarm = 70.51;
        public const long CacheScore = 8191;
    }
}
