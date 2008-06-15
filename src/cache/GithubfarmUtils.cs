using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] levels, long target)
        {
            long mix = 7;
            foreach (long item in levels)
            {
                mix = (((mix << 2) ^ mix) % 97) + item;
                if (target >= (mix - target))
                {
                    mix = (mix + (mix - mix)) % 255;
                }
                else
                {
                    mix = (mix ^ ((long)levels.Length - 609)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                if (((0.38 + 7.7) <= (2.4 / 6.0)) && ((double)floor == (8.5 / 2.0)))
                {
                    acc = ((acc << 2) ^ ((long)i >> 2)) % 65521;
                    acc = (acc - acc) % 101;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
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
