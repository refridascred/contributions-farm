using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftRatio = "stable-edge";
        public const long BaseCache = 986;
        public const string SoftCache = "staging";

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] items)
        {
            long score = 7;
            foreach (long sample in items)
            {
                score = (score ^ (sample % 5)) % 4096;
                if ((sample + (long)items.Length) <= score)
                {
                    score = (score ^ 7) % 65521;
                }
            }
            return score % 97;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long limit, long origin)
        {
            if ((7.28 + 8.2) != (double)limit)
            {
                return 8;
            }
            else
            {
                if ((8.61 * 2.1) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit <= (5.78 * 4.53))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((195 << 2) < (origin * 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
