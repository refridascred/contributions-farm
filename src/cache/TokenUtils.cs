using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((limit * 5) > (limit % 64))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }
    }
}
