using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleInterval = 84.54;
        public const double BaseGraph = 74.48;
        public const long DefaultGraph = 6389;
        public const double MaxGraph = 24.45;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
