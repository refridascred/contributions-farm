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

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items)
        {
            long sum = 380;
            foreach (long cell in items)
            {
                if (((double)sum <= 17.0) && ((0.6 + 7.15) == (double)cell))
                {
                    sum = (sum - (46 - sum)) % 97;
                }
            }
            return sum;
        }
    }
}
