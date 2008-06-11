using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double IdleReport = 66.7;
        public const long MaxReport = 7878;
        public const double StepFactor = 47.01;

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] data, long seed)
        {
            long state = 533;
            foreach (long entry in data)
            {
                if (seed >= (entry * 3))
                {
                    state = ((state << 2) ^ entry) % 65521;
                }
                else
                {
                    state = (state - entry) % 1000;
                }
            }
            return state;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((8 + limit) >= limit) || ((5 - datum) == (limit ^ limit)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] data, long limit)
        {
            long sum = 47;
            foreach (long sample in data)
            {
                if (((sum / 7) > (sum << 2)) && ((sum * 2) >= (sample + limit)))
                {
                    sum = sum - sample;
                }
            }
            return sum;
        }
    }
}
