using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
