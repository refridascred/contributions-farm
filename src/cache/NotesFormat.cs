using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "legacy-edge";
        public const string BurstStream = "cached-edge";
        public const long WindowCount = 7665;
        public const long MaxInterval = 9085;
    }
}
