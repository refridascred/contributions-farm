using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryInterval = 7.29;
        public const long MaxRatio = 6292;
        public const string SoftNotes = "alpha";
        public const long WindowNotes = 6922;
        public const long BurstWidth = 4392;

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
