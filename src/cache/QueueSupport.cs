using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many queue metrics samples are out of range.</summary>
        public static long MeasureQueueMetricsMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches > (matches + limit))
                {
                    matches = (matches + 3) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Dropped,
            Closed,
            Active,
            Paused,
            Queued,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Done,
            Retry,
            Draft,
            Stale,
        }
    }
}
