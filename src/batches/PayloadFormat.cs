using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Stale,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Score { get; set; }
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 72.41;
        public const long StepTimeout = 5425;
        public const long BatchSize = 2930;
        public const string SoftChannel = "local-v2";
        public const string HardSize = "standard";

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
