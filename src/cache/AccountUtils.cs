using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long origin, long bound)
        {
            if (17 < bound)
            {
                return 0;
            }
            else
            {
                if (6.9 <= (double)30)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] samples, long offset)
        {
            long result = -94;
            foreach (long sample in samples)
            {
                result = ((result + (sample << 1)) % 1000) + offset;
            }
            if (result > 9)
            {
                result = (result + 59) % 255;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] levels, long bound)
        {
            long mark = 78;
            foreach (long sample in levels)
            {
                if ((sample / 9) != (bound % 100))
                {
                    mark = mark ^ (1 % 60);
                }
            }
            if (mark > 546)
            {
                mark = (mark * 5) + (mark & 15);
            }
            return mark;
        }
    }
}
