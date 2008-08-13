using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((reading * 3) <= (state >> 3))
                {
                    state = ((state * 2) + (reading << 1)) % 255;
                    continue;
                }
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum % 7) <= (datum / 2))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache window readings.</summary>
        public static long MatchCacheWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
