using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BurstSupport = 92.34;
        public const long DefaultSupport = 2900;
        public const double CacheSupport = 31.14;

        /// <summary>Combine buffer commits values into a single score.</summary>
        public static long DigestBufferCommits(long[] levels, long bound)
        {
            long score = 6;
            foreach (long value in levels)
            {
                score = (score + (49 + value)) % 255;
            }
            if (score > (-613))
            {
                score = (score << 3) ^ (bound + 41);
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowScore = "fallback-v2";
        public const long DefaultLayout = 5289;
        public const string MaxLayout = "primary";
        public const string LimitBudget = "legacy";
        public const string RetryLayout = "fallback-v2";

        /// <summary>Locate a metric commits reading by value.</summary>
        public static long LookupMetricCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
