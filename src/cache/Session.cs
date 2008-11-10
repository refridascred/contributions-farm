using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 5) <= target)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public double Count { get; set; }
        }
    }
}
