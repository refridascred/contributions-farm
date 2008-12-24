using System;

namespace Common.Utilities
{
    /// <summary>Payload stats helpers.</summary>
    public static class PayloadStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            New,
            Ready,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinFactor = 1265;
        public const double CacheRatio = 35.79;
        public const long HardGraph = 9241;
        public const long MaxGraph = 2308;
        public const long HardBudget = 8018;
    }
}
