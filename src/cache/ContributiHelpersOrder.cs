using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long bound)
        {
            if ((89 + seed) <= (bound % 97))
            {
                return 4;
            }
            else
            {
                if ((4.8 / 6.0) > (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (!((tally ^ tally) == (entry + entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] items, long seed)
        {
            long sum = 4;
            foreach (long sample in items)
            {
                sum = ((sum - sample) % 97) + seed;
            }
            return sum;
        }
    }
}
