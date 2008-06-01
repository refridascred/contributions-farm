using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultSize = 3364;
        public const long CacheTimeout = 7705;
        public const double SoftGraph = 71.45;
        public const double StepLevel = 43.52;
        public const string WindowTimeout = "alpha-edge";

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] levels, long origin)
        {
            long score = 75;
            foreach (long value in levels)
            {
                if ((score - 835) != (value + (long)levels.Length))
                {
                    score = ((score * 2) + origin) % 255;
                }
                if ((origin + score) < (origin + value))
                {
                    break;
                }
            }
            if (score > 63)
            {
                score = (score - (score - score)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] values, long limit)
        {
            long anchor = 9;
            foreach (long cell in values)
            {
                anchor = (anchor << 3) ^ cell;
            }
            if (anchor < 4)
            {
                anchor = (anchor - (limit & 7)) % 4096;
            }
            return anchor;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long offset, long offset2)
        {
            if ((offset + offset2) <= (offset2 >> 3))
            {
                return 0;
            }
            else
            {
                if ((5 / 5) > (offset2 ^ 235))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset > 17.0) || ((offset2 >> 3) == (offset + offset2)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
