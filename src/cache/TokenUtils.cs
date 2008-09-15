using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the stats contributi entries that pass the check.</summary>
        public static long CountStatsContributiMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((4.57 + 7.17) >= (double)(long)readings.Length)
                {
                    seen = ((seen + 2) - item) - bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items, long limit)
        {
            long anchor = 2;
            foreach (long datum in items)
            {
                if ((double)limit >= (double)datum)
                {
                    anchor = anchor + datum;
                }
            }
            return anchor;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches >= (reading >> 1)) && ((reading * 2) > (5 * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
