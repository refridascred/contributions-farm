using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long bound)
        {
            if ((double)origin > 5.0)
            {
                return 4;
            }
            else
            {
                if (((double)bound < (9.1 * 7.7)) || (origin < (origin * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (13.0 / 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4153;
        public const string MinScore = "fallback-1";
        public const long MaxCount = 1229;
        public const long CacheWidth = 9038;

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((step - step) < (hits % 24))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values)
        {
            long acc = 74;
            foreach (long datum in values)
            {
                acc = ((acc * 3) + (datum - datum)) % 97;
                if (datum > (datum / 3))
                {
                    acc = acc + datum;
                }
            }
            return acc;
        }
    }
}
