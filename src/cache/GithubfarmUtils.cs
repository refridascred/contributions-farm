using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Draft,
            Paused,
            New,
            Ready,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell < (46 & 31))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Find the first editor queue entry that matches the target.</summary>
        public static long FindEditorQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
