using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 1754;
        public const string CacheAlready = "standard";
        public const long DefaultAlready = 7022;
        public const string BatchAlready = "primary";

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchCount = 3779;
        public const long BatchSession = 4489;
        public const string WindowSpan = "primary-edge";
    }
}
