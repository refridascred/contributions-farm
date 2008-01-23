using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string HardCount = "fallback-v2";
        public const double DefaultBatch = 68.19;
        public const string MinBatch = "legacy-1";
        public const string LimitSize = "local-edge";

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "local-1";
        public const double DefaultLayout = 96.7;
        public const double IdleLayout = 60.43;
        public const long LimitBudget = 7502;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
