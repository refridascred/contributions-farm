using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (origin >= (item - origin))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitLevel = 4137;
        public const long BurstSession = 4276;
        public const double CacheLevel = 23.22;

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits % 3) > entry)
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }
    }
}
