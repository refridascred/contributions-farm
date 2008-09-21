using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((floor % 10) != (seen ^ (long)levels.Length))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] levels)
        {
            long sum = 37;
            foreach (long cell in levels)
            {
                sum = ((sum + ((long)levels.Length & 127)) % 97) ^ cell;
            }
            return sum;
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
