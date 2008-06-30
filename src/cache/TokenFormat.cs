using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] levels)
        {
            long acc = 90;
            foreach (long sample in levels)
            {
                if (((sample - acc) > (acc + 570)) || ((sample & 63) >= (sample / 9)))
                {
                    acc = (acc + (sample + acc)) % 65521;
                }
                if (acc > (sample + acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((8.2 / 5.0) >= (double)bound)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Find the first support contributi entry that matches the target.</summary>
        public static long LocateSupportContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
