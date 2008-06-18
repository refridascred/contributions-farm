using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4665;
        public const long SoftCount = 5636;
        public const long WindowCommand = 7679;
        public const long MinCommand = 2096;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)reading > (5.9 / 5.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits - sample) <= hits)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }
    }
}
