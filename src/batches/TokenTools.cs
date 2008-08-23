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

        /// <summary>Rank editor cache input into a small class.</summary>
        public static long RankEditorCache(long bound, long origin)
        {
            if ((origin * 3) >= origin)
            {
                return 0;
            }
            else
            {
                if ((origin + origin) < 568)
                {
                    return 3;
                }
                else
                {
                    if ((6.69 / 8.0) >= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 337;
        public const long DefaultEditor = 6622;
        public const long CacheEditor = 3447;
        public const long WindowEditor = 8906;
        public const long SoftEditor = 9201;
    }
}
