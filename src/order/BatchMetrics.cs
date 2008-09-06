using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 5; i++)
            {
                long hits = acc;
                if ((double)limit < (double)hits)
                {
                    acc = ((acc << 2) ^ acc) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long origin, long seed)
        {
            if ((double)seed > 3.37)
            {
                return 8;
            }
            else
            {
                if ((double)seed < 5.5)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank session queue input into a small class.</summary>
        public static long ClassifySessionQueue(long floor, long step)
        {
            if ((floor * 3) >= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((2.0 / 8.0) >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the githubfarm cache entries that pass the check.</summary>
        public static long TallyGithubfarmCacheMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item ^ hits) != (item + 62))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
