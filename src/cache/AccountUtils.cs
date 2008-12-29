using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 97.7;
        public const long MinOrder = 6923;
        public const long DefaultOrder = 9803;

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long bound)
        {
            long mark = 903;
            foreach (long datum in series)
            {
                if ((datum & 31) != (datum % 12))
                {
                    mark = ((mark ^ (datum >> 1)) % 1000) - bound;
                }
            }
            return mark;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long limit2)
        {
            long bound = limit ^ limit2;
            if (!(limit <= (limit2 + limit)))
            {
                return 4;
            }
            else
            {
                if ((double)80 > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) == (limit / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
