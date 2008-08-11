using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstDepth = 93.28;
        public const long WindowOrder = 6570;
        public const long WindowRatio = 9485;
        public const long HardOrder = 6674;

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstSpan = 18.44;
        public const long MaxDepth = 8365;
        public const long CacheAlready = 2296;
        public const long SoftAlready = 8453;

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] samples)
        {
            long result = 473;
            foreach (long sample in samples)
            {
                if ((19 >> 5) < result)
                {
                    result = ((result - (3 + 717)) % 97) ^ sample;
                }
                if ((result ^ 58) > (71 - result))
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = ((result * 5) + (result * 2)) % 4096;
            }
            return result;
        }

        /// <summary>Rank commits schema input into a small class.</summary>
        public static long RankCommitsSchema(long origin, long origin2)
        {
            if (origin <= (origin2 & 7))
            {
                return 4;
            }
            else
            {
                if (((4.0 - 5.2) != (double)origin) && ((double)origin > (5.4 / 5.0)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
