using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double CacheRatio = 90.74;
        public const double HardSession = 70.7;
        public const long SoftSize = 9711;
        public const long MaxInterval = 9229;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Closed,
            Stale,
            Retry,
            New,
        }

        /// <summary>Measure how many session cluster samples are out of range.</summary>
        public static long MeasureSessionClusterGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits >= (hits + hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
