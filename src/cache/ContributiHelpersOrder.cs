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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((double)origin < (19.0 * 14.0)) && ((value / 7) <= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

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
