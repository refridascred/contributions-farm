using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Queued,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultLevel = 6184;
        public const double BaseInterval = 19.35;
        public const string BatchGraph = "stable-edge";
    }
}
