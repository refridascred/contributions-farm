using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Failed,
            Ready,
            New,
            Locked,
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchInterval = 5.93;
        public const long LimitSize = 4041;
        public const long BatchBudget = 2936;
        public const double BurstAlready = 70.63;
    }
}
