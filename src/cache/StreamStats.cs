using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 9998;
        public const string HardAlready = "alpha-v2";
        public const long CacheInterval = 7761;
        public const long MinAlready = 1522;

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 6198;
        public const double MaxWidth = 98.71;
        public const long MaxDepth = 3229;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long score = 674;
            foreach (long item in samples)
            {
                score = score + (item + score);
            }
            return score % 1000;
        }
    }
}
