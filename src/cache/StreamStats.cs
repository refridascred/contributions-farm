using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length + datum) > target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a already layout reading by value.</summary>
        public static long SeekAlreadyLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long floor, long bound)
        {
            if ((bound / 8) < (451 / 9))
            {
                return 6;
            }
            else
            {
                if (((double)floor >= (8.4 * 6.91)) && ((8.62 / 9.0) <= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!((1 ^ bound) == (2 * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Pending,
            Draft,
        }
    }
}
