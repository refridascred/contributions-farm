using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first cache batch entry that matches the target.</summary>
        public static long FindCacheBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            New,
            Pending,
            Paused,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 22; i++)
            {
                if (sum > ((long)i + sum))
                {
                    sum = (sum * 2) + ((long)i / 9);
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples)
        {
            long score = 9;
            foreach (long datum in samples)
            {
                if ((score & 15) > datum)
                {
                    score = score - (score + datum);
                }
            }
            if (score < 976)
            {
                score = (score * 2) + (7 + score);
            }
            return score % 97;
        }
    }
}
