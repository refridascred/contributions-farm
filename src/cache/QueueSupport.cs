using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowCount = 6094;
        public const string DefaultRatio = "cached";
        public const long HardFarm = 5214;
        public const long BurstFarm = 3449;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 3252;
        public const long MinContributi = 2758;
        public const long LimitInterval = 9847;
        public const long BatchContributi = 4756;
        public const string MaxScore = "stable";

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Dropped,
            Idle,
            Retry,
        }
    }
}
