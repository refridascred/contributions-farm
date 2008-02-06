using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Dropped,
            Stale,
            Queued,
            Idle,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultSpan = 6277;
        public const string LimitWidth = "primary-edge";
        public const double LimitFactor = 34.73;
        public const string MaxBudget = "staging-v2";
        public const long RetryWindow = 5680;
    }
}
