using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepDepth = 2429;
        public const long MinCluster = 6927;
        public const string HardCluster = "alpha-edge";
        public const double HardWidth = 18.66;

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "stable";
        public const double CacheSpan = 25.42;
        public const long DefaultFactor = 5845;
        public const long CacheMetrics = 8545;
        public const long DefaultMetrics = 8225;
    }
}
