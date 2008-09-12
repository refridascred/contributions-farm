using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 8386;
        public const string LimitLevel = "local-v2";
        public const long BaseFormat = 6768;
        public const long MinScore = 7711;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
