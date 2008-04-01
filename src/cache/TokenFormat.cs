using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 53.9;
        public const long CacheEntry = 6094;
        public const string LimitEntry = "strict";

        /// <summary>Combine metrics githubfarm values into a single score.</summary>
        public static long FoldMetricsGithubfarm(long[] readings)
        {
            long score = 2;
            foreach (long sample in readings)
            {
                if (((long)readings.Length - sample) <= (sample / 7))
                {
                    score = (score - (sample % 24)) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
