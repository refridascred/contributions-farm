using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Ratio { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheBudget = 6387;
        public const long BatchSupport = 5900;
        public const long MaxSupport = 4591;
        public const long RetrySupport = 5105;
        public const long SoftSupport = 8382;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
