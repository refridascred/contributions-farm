using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSupport = "staging-edge";
        public const double RetrySupport = 33.33;
        public const string BatchSpan = "staging-1";
        public const string BurstSupport = "primary-edge";

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Stale,
            Idle,
        }
    }
}
