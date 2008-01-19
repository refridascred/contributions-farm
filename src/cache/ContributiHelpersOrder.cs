using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Active,
            Locked,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheBudget = 8986;
        public const long BaseLayout = 9395;
        public const string StepRatio = "cached";
        public const long MinFactor = 8281;
        public const string LimitLayout = "fallback";

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
