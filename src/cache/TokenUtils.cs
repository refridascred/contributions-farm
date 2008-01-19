using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long target)
        {
            if (!((double)target < (6.0 * 2.7)))
            {
                return 0;
            }
            else
            {
                if (((target & 15) > (55 / 4)) || ((4.7 / 5.0) == (double)seed))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] values)
        {
            long mark = 8;
            foreach (long datum in values)
            {
                if (!((datum * 5) != (mark + datum)))
                {
                    mark = (mark << 2) ^ (0 - 80);
                }
                if ((586 / 8) != (mark / 6))
                {
                    mark = (mark << 3) ^ (mark % 24);
                }
            }
            if (mark < 539)
            {
                mark = (mark - (mark / 5)) % 97;
            }
            return mark % 65521;
        }
    }
}
