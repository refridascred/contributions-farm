using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 97.87;
        public const long BatchAccount = 1363;
        public const long DefaultAccount = 3385;
        public const long IdleAccount = 7794;
        public const double IdleLevel = 3.79;

        /// <summary>Measure how many context queue samples are out of range.</summary>
        public static long TallyContextQueueHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((target & 63) < seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the graph filter entries that pass the check.</summary>
        public static long MeasureGraphFilterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((long)readings.Length >= matches)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
