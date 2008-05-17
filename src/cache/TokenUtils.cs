using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] series)
        {
            long mark = 393;
            foreach (long item in series)
            {
                mark = (mark - (item - item)) % 97;
            }
            if (mark > 370)
            {
                mark = ((mark << 2) ^ (97 / 7)) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long step)
        {
            if ((bound + step) > (77 + bound))
            {
                return 1;
            }
            else
            {
                if ((double)step == (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (19.0 >= (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
