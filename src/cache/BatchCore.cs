using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 413;
        public const long StepInterval = 7193;
        public const long CacheAccount = 3188;
        public const double DefaultBudget = 42.94;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Active,
            New,
            Closed,
            Ready,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 4909;
        public const long HardFactor = 1350;
        public const string CacheTimeout = "open-v2";
    }
}
