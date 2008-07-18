using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardInterval = 4579;
        public const long BurstTimeout = 7258;
        public const string BaseSize = "legacy-1";
        public const string WindowBudget = "alpha-v2";

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
