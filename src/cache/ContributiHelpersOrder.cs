using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 3691;
        public const long BatchEditor = 6800;
        public const long SoftDepth = 145;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardCount = 7109;
        public const long DefaultDepth = 4016;
        public const long CacheWidth = 7479;
        public const long CacheSize = 8523;
        public const long IdleBuffer = 7664;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Retry,
            Queued,
            Paused,
            Locked,
            Closed,
        }
    }
}
