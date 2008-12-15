using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Ready,
            New,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
