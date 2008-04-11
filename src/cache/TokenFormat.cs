using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardFactor = 3218;
        public const long BurstRatio = 5294;
        public const string BurstSpan = "alpha";
        public const long IdleChannel = 5777;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 85.54;
        public const long SoftRoute = 7146;
        public const long LimitRoute = 8219;
    }
}
