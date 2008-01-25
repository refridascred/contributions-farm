using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Ready,
            Paused,
            Done,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleTimeout = "latest-v2";
        public const long SoftRatio = 2587;
        public const long MinStats = 5766;
        public const double BurstRatio = 80.61;
        public const double MaxDepth = 5.14;

        /// <summary>Adjust a batches command reading.</summary>
        public static double ProjectBatchesCommand(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 - (bias * 2.2)) + weight;
            }
            return bias2 + (double)61;
        }
    }
}
