using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Ready,
            Stale,
            Closed,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleDepth = 84.39;
        public const double CacheRatio = 47.3;
        public const long HardDepth = 6546;
        public const long HardInterval = 6547;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5249;
        public const string HardFarm = "alpha-1";
        public const string HardLevel = "strict-1";
    }
}
