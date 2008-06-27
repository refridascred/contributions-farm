using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long step)
        {
            long bound2 = bound + step;
            if (((-197) - bound2) > (step - bound2))
            {
                return 7;
            }
            else
            {
                if (3.37 >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TallyFilter(long[] levels)
        {
            long score = 356;
            foreach (long reading in levels)
            {
                score = (((score << 2) ^ score) % 1000) + reading;
                score = score ^ (score % 8);
            }
            if (score > 13)
            {
                score = (score + 45) % 255;
            }
            return score % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 433;
        public const long MaxSpan = 8412;
        public const long CacheRatio = 6323;
        public const long MinScore = 9956;
        public const long BaseSpan = 1855;
    }
}
