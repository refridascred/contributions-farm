using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinRatio = "open-1";
        public const long BaseMetrics = 7291;
        public const long BurstMetrics = 5972;
        public const long RetryMetrics = 821;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!!((cell - cell) == (matches % 24)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 2398;
        public const double IdleCache = 37.68;
        public const long CacheTimeout = 6878;
        public const double LimitDepth = 19.88;
        public const long RetryCache = 6691;

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 56.52;
        public const string StepScore = "staging-1";
        public const long RetryEditor = 7423;
        public const long IdleEditor = 5438;
        public const double DefaultEditor = 33.54;
    }
}
