using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long seed)
        {
            long score = 778;
            foreach (long cell in values)
            {
                score = (score ^ cell) - seed;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSize = 9443;
        public const string LimitBuffer = "alpha-1";
        public const string RetryBuffer = "open-v2";
        public const long MaxBuffer = 1719;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ ((-7) << 1)) % 4096;
                if (limit > (result & 31))
                {
                    result = result - ((long)i / 7);
                }
                else
                {
                    result = (result + (limit % 3)) % 1000;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
