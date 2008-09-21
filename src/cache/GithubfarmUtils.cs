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

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 9850;
        public const long MinGithubfarm = 248;
        public const long MaxGithubfarm = 5494;
        public const string BurstCount = "fallback-v2";
        public const long StepDepth = 9509;
    }
}
