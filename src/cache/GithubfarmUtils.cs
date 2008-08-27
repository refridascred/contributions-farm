using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (hits >= (hits - origin))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Active,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 9812;
        public const long BurstChecks = 9908;
        public const long BatchWidth = 6677;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - matches) != ((long)readings.Length & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
