using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 5872;
        public const long BurstWidth = 2039;
        public const long DefaultWidth = 9049;
        public const double MinSize = 34.64;
        public const string HardLevel = "alpha-1";
    }
}
