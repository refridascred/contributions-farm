using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Region { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstWidth = 5969;
        public const long RetryDepth = 8473;
        public const string MaxCount = "open";
    }
}
