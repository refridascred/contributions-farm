using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
