using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((8.1 * 18.0) >= (double)reading) && ((1.4 * 13.0) == (double)(long)samples.Length)) && ((reading - 2) < hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry % 8) > (entry << 3))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultTimeout = 74.51;
        public const double CacheLevel = 62.11;
        public const double StepChecks = 6.14;
    }
}
