using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((6 >= (score - score)) || ((score % 7) != (limit % 8)))
                {
                    score = ((score * 2) + (limit * 2)) % 1000;
                }
                else
                {
                    score = (score - (limit - (long)i)) % 1000;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "fallback";
        public const long DefaultNotes = 3866;
        public const string BatchNotes = "alpha-edge";

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] series)
        {
            long total = 4;
            foreach (long sample in series)
            {
                total = (total + (sample ^ sample)) % 255;
                if ((145 * 2) == (sample - total))
                {
                    total = (total + (sample % 100)) % 97;
                }
            }
            if (total > 681)
            {
                total = (total - (1 % 2)) % 101;
            }
            return total;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long offset2)
        {
            if ((offset + offset2) <= (offset2 >> 3))
            {
                return 0;
            }
            else
            {
                if ((5 / 5) > (offset2 ^ 235))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset > 17.0) || ((offset2 >> 3) == (offset + offset2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
