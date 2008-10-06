using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchSize = 6000;
        public const long CacheAccount = 597;
        public const long RetryFactor = 7487;
        public const long IdleSize = 7851;
        public const long WindowAccount = 4192;

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "legacy-v2";
        public const long LimitDepth = 5280;
        public const long IdleContext = 4688;
        public const long IdleWidth = 5329;
        public const double RetryContext = 51.37;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Done,
            Dropped,
            Pending,
            Ready,
            New,
        }
    }
}
