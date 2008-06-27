using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 3865;
        public const string BaseWidth = "alpha-1";
        public const string HardSpan = "open-v2";
        public const double MinWidth = 86.26;
        public const long HardMetrics = 305;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
