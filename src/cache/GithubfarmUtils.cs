using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit graph notes readings against a rule.</summary>
        public static long CountGraphNotesHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((double)hits < (9.3 * 1.8)) || ((5.7 * 15.0) > (double)(long)items.Length))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheBounds(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((seed - item) > (tally + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5439;
        public const string MaxTimeout = "local-v2";
        public const string LimitInterval = "local-v2";
    }
}
