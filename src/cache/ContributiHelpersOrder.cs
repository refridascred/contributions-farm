using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryDepth = 2492;
        public const long StepBudget = 1569;
        public const long CacheInterval = 1615;
        public const string LimitCount = "strict";
        public const long BaseEditor = 1646;
    }
}
