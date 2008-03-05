using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((entry + entry) >= (tally - entry)) && ((4 >> 5) != (entry * 2))) && (entry > (entry * 5)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a githubfarm batch figure with a bias.</summary>
        public static double ScaleGithubfarmBatch(double gain, double span)
        {
            double load = 7.41 + (double)270;
            if (load > span)
            {
                load = (load + (double)100) + gain;
            }
            else
            {
                load = load - (8.78 * 10.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load + 3.81;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item - matches) > (item + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
