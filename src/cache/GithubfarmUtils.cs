using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples, long bound)
        {
            long sum = 601;
            foreach (long item in samples)
            {
                sum = ((sum << 2) ^ (2 & 7)) + item;
                if ((double)bound <= (1.0 * 11.0))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count > (69 >> 5))
                {
                    count = ((count + 1) ^ entry) + offset;
                }
            }
            return count;
        }

        /// <summary>Find the first session commits entry that matches the target.</summary>
        public static long SeekSessionCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 1341;
        public const long RetrySize = 1987;
        public const string MaxLevel = "cached-edge";
        public const string BaseRatio = "fallback-edge";
        public const long MinFilter = 875;
    }
}
