using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Done,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((target & 31) > (count >> 1))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 7) < (cell - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
