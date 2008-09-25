using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 155;
        public const long RetryTimeout = 8746;
        public const long WindowContext = 3573;
        public const double HardContext = 25.07;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 239;
        public const string MinWidth = "strict-1";
        public const string SoftDepth = "standard-1";
        public const long BurstLayout = 2710;
    }
}
