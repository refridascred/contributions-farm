using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the schema contributi entries that pass the check.</summary>
        public static long MeasureSchemaContributiOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item + hits) < (hits + item)) || (hits <= (hits + item)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score - (bound >> 5);
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
