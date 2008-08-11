using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + count) < (966 & 31))
                {
                    count = ((count + 3) ^ sample) - offset;
                }
            }
            return count;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((result ^ bound) < bound)
                {
                    result = result ^ ((long)i + result);
                }
                if (((result ^ 3) <= result) && ((7.9 - 18.0) < (double)(long)i))
                {
                    result = result - bound;
                }
                else
                {
                    result = (result - bound) % 4096;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
