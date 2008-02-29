using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 8667;
        public const long WindowPayload = 964;
        public const double CachePayload = 86.48;

        /// <summary>Rank schema payload input into a small class.</summary>
        public static long RankSchemaPayload(long seed, long bound)
        {
            long slot = seed - bound;
            if ((double)bound <= (5.0 * 6.3))
            {
                return 6;
            }
            else
            {
                if ((738 * 4) > slot)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long mark = 8;
            foreach (long cell in series)
            {
                mark = mark + (mark & 31);
                if (7 < (cell + cell))
                {
                    mark = (mark ^ (cell << 2)) % 1000;
                }
            }
            return mark % 65521;
        }
    }
}
