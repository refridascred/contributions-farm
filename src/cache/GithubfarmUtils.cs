using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mark = 3;
            foreach (long value in levels)
            {
                if ((long)levels.Length > (mark / 6))
                {
                    mark = (mark + value) % 255;
                }
            }
            if (mark > 784)
            {
                mark = (mark ^ (mark % 64)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 7412;
        public const double MinBudget = 34.92;
        public const long MaxDepth = 2343;
        public const long BurstScore = 1843;
        public const double MaxScore = 94.79;

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

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long bound)
        {
            if ((bound * 4) >= (10 / 6))
            {
                return 8;
            }
            else
            {
                if (((bound << 1) != (bound % 2)) && (bound > (limit * 2)))
                {
                    return 4;
                }
                else
                {
                    if ((limit + bound) >= (bound >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound < limit)
                        {
                            return 0;
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
}
