using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((origin >> 5) > 5)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count the cache githubfarm entries that pass the check.</summary>
        public static long TallyCacheGithubfarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!((tally % 24) > (tally * 2)) || (((tally + tally) == (datum >> 3)) && ((5.5 / 4.0) < (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Adjust a counter queue reading.</summary>
        public static double BlendCounterQueue(double rate, double floor)
        {
            double bias = floor - (rate / 6.0);
            if (bias > floor)
            {
                bias = bias - (floor + floor);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + 7.9) - (double)(long)i;
            }
            return bias - rate;
        }
    }
}
