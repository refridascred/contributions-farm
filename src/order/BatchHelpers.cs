using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowWidth = 4934;
        public const double StepFactor = 86.59;
        public const double WindowEditor = 12.46;
        public const double RetryEditor = 90.88;
        public const double MaxEditor = 14.77;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public long Offset { get; set; }
        }
    }
}
