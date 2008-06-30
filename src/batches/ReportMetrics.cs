using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 5874;
        public const string BatchCommand = "legacy-edge";
        public const long SoftCommand = 9579;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
