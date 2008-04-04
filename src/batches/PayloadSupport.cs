using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            New,
            Locked,
            Synced,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseSize = 1.24;
        public const long BatchToken = 3459;
        public const long MaxTimeout = 3353;
        public const string LimitTimeout = "latest-v2";
        public const long WindowToken = 247;
    }
}
