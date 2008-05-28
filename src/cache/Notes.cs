using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a already stats reading by value.</summary>
        public static long LocateAlreadyStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the cache layout series from a seed.</summary>
        public static long SeriesCacheLayout(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc * 3) + (step * 3);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Idle,
            Pending,
            Stale,
            Failed,
        }
    }
}
