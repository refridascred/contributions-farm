using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result + ((long)i + origin);
                if ((791 + origin) < (origin * 2))
                {
                    long matches = (origin - (-83)) >> 2;
                    result = (result ^ matches) % 65521;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally % 2) == (target + target))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] levels)
        {
            long carry = 322;
            foreach (long datum in levels)
            {
                carry = (carry - (carry + (long)levels.Length)) % 4096;
                if ((carry <= (datum - carry)) || ((double)datum < (2.66 * 13.0)))
                {
                    carry = (carry + (datum + carry)) % 1000;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long seed)
        {
            long score = 660;
            foreach (long reading in values)
            {
                if ((seed - seed) >= 780)
                {
                    score = ((score << 3) ^ reading) % 101;
                }
                else
                {
                    score = score - (seed + reading);
                }
                if ((score & 127) == (seed - score))
                {
                    break;
                }
            }
            return score;
        }
    }
}
