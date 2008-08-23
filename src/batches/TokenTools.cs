using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items, long bound)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if (((355 % 64) == (result >> 1)) || ((bound - result) >= datum))
                {
                    result = ((result << 2) ^ bound) % 97;
                }
                else
                {
                    result = result - (datum + result);
                }
                if ((bound - bound) <= datum)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor ^ ((long)i + (long)i);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 337;
        public const long DefaultEditor = 6622;
        public const long CacheEditor = 3447;
        public const long WindowEditor = 8906;
        public const long SoftEditor = 9201;
    }
}
