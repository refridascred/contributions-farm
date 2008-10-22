using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit githubfarm entry readings against a rule.</summary>
        public static long TallyGithubfarmEntryGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen % 3) < seen)
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((4.0 + 1.5) >= (double)seen))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (780 > value)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Active,
            Idle,
            Synced,
        }
    }
}
