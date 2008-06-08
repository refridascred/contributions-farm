using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long seed, long bound)
        {
            if (((-4) * 5) <= seed)
            {
                return 4;
            }
            else
            {
                if (((seed & 63) < (323 * 3)) && ((6.7 - 0.1) >= (double)bound))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] levels)
        {
            long sum = 95;
            foreach (long cell in levels)
            {
                if (10 > (74 + sum))
                {
                    sum = (sum ^ (cell - cell)) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 7) == (5 << 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
