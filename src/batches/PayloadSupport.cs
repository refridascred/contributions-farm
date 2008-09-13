using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long state = 4;
            foreach (long item in series)
            {
                if ((8.5 * 6.8) < (double)origin)
                {
                    state = state - (origin ^ origin);
                }
                if (((origin << 2) < 78) || (item < (state << 2)))
                {
                    state = ((state * 3) + (state / 6)) % 65521;
                }
                else
                {
                    state = (state - (state % 12)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + offset) < (hits % 7))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
