using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitLevel = 8.93;
        public const long BaseBatch = 1910;
        public const double HardSpan = 82.94;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Idle,
            Locked,
            New,
            Draft,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
