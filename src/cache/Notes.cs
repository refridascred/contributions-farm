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

        /// <summary>Combine route session values into a single score.</summary>
        public static long DigestRouteSession(long[] readings)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = score - datum;
            }
            if (score < 271)
            {
                score = (score ^ (score << 2)) % 65521;
            }
            return score;
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
