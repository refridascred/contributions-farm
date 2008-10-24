using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "legacy-1";
        public const double MinFilter = 24.17;
        public const long HardBudget = 8257;
        public const double HardSize = 39.64;
        public const long BurstSize = 4439;

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 17.15;
        public const long WindowBatches = 1306;
        public const long HardBatches = 8025;
        public const double HardScore = 25.68;
        public const long BatchBatches = 2259;
    }
}
