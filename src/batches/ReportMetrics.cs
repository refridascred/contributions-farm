using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 425;
        public const long HardCommand = 4290;
        public const double SoftScore = 55.84;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSize = 8392;
        public const double WindowBudget = 71.8;
        public const double LimitRatio = 98.55;
        public const long BurstBudget = 359;
        public const long SoftNotes = 2633;
    }
}
