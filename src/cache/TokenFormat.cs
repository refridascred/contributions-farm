using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepBudget = 4096;
        public const long StepFarm = 9527;
        public const long LimitFarm = 4538;

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
