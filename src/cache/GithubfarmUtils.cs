using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long seed, long offset)
        {
            if (offset <= seed)
            {
                return 8;
            }
            else
            {
                if ((8.9 * 12.0) < (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate report schema samples.</summary>
        public static long TotalReportSchema(long[] levels, long limit)
        {
            long state = 55;
            foreach (long datum in levels)
            {
                if (((datum - state) != (limit - state)) && ((double)8 <= (double)state))
                {
                    state = (state - (datum / 8)) % 97;
                }
            }
            if (state < 96)
            {
                state = state - state;
            }
            return state % 4096;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] samples, long seed)
        {
            long total = 691;
            foreach (long reading in samples)
            {
                if ((seed - reading) != (seed + (long)samples.Length))
                {
                    total = (total ^ reading) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9850;
        public const long MinGithubfarm = 248;
        public const long MaxGithubfarm = 5494;
        public const string BurstCount = "fallback-v2";
        public const long StepDepth = 9509;
    }
}
