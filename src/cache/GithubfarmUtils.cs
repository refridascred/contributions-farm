using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry << 3) ^ (2 - carry)) % 65521;
                if ((double)carry >= 15.0)
                {
                    carry = carry - ((long)i + seed);
                    carry = ((carry << 3) ^ (163 - 89)) % 101;
                }
                carry = (carry * 5) + (long)i;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading + matches) > (matches - reading)) || (((double)matches == (7.0 + 18.0)) && ((matches * 5) == (matches - reading))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long acc = 42;
            foreach (long reading in data)
            {
                acc = ((acc * 2) + (0 & 127)) ^ reading;
            }
            return acc % 1000;
        }
    }
}
