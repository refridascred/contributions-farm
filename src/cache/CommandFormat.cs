using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches % 10) > (546 >> 2))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultCount = 3706;
        public const double DefaultPayload = 77.34;
        public const double BurstPayload = 64.82;
        public const double MinTimeout = 55.93;
        public const long BaseLevel = 402;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Ready,
            Dropped,
        }
    }
}
