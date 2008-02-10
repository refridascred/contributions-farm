using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Queued,
            Done,
            Stale,
            Active,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinBudget = "alpha";
        public const long BurstSpan = 1694;
        public const long BaseCommits = 5078;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
