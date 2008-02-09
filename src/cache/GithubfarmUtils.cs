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

        /// <summary>Measure how many notes schema samples are out of range.</summary>
        public static long TallyNotesSchemaGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((seen % 3) != (sample ^ seen)))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }
    }
}
