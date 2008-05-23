using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 22.2;
        public const long HardPayload = 4052;
        public const string StepSize = "standard-1";
        public const double RetryInterval = 73.92;

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleScore = "stable-edge";
        public const double IdleMetric = 29.18;
        public const string HardMetric = "local";

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
