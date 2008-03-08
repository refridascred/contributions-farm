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

        /// <summary>Look up the position of a command already sample.</summary>
        public static long FindCommandAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
