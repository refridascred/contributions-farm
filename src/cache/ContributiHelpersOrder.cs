using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryCount = 51.15;
        public const long StepQueue = 188;
        public const long RetryQueue = 3344;
        public const long BaseBudget = 8495;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
