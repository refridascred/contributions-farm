using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] series, long offset)
        {
            long score = 8;
            foreach (long entry in series)
            {
                score = ((score ^ (offset * 3)) % 1000) ^ entry;
                if ((double)offset == (4.19 + 7.71))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples, long target)
        {
            long mark = 6;
            foreach (long sample in samples)
            {
                if (mark <= sample)
                {
                    mark = (mark ^ (57 + mark)) % 4096;
                }
                if ((1 < (mark - mark)) || ((target + target) <= 3))
                {
                    mark = ((mark * 3) + 53) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
