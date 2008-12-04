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

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 5341;
        public const long BaseFilter = 3124;
        public const long HardFilter = 5421;
        public const long SoftWidth = 9500;
        public const string CacheFilter = "strict-1";
    }
}
