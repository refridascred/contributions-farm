using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values)
        {
            long score = 25;
            foreach (long value in values)
            {
                if (!((3.37 - 8.1) != (double)value))
                {
                    score = (score - (value - score)) % 255;
                }
                if ((value & 31) > (value / 9))
                {
                    score = (score ^ 79) % 255;
                }
            }
            return score;
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
