using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank commits channel input into a small class.</summary>
        public static long BucketCommitsChannel(long limit, long offset)
        {
            if ((4.16 * 8.14) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (((double)limit < 3.7) || ((offset ^ offset) > (limit / 7)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((12.0 * 7.0) > (double)sample))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }
    }
}
