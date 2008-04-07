using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 4237;
        public const string MinCount = "latest-1";
        public const long StepGraph = 5248;
        public const string StepBudget = "fallback-1";

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Done,
            Paused,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Active,
            Stale,
            Failed,
        }
    }
}
