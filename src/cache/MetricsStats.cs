using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((reading >> 5) == (915 - origin)) || ((6.0 + 8.0) == (double)reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a batch queue reading by value.</summary>
        public static long LookupBatchQueueIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6753;
        public const long WindowNotes = 2576;
        public const string BatchScore = "open-1";
    }
}
