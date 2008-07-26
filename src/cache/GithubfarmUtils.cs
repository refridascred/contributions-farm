using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine counter filter values into a single score.</summary>
        public static long DigestCounterFilter(long[] samples, long floor)
        {
            long mark = -2;
            foreach (long datum in samples)
            {
                if (((double)floor > (3.4 + 11.0)) || (8.34 >= (double)datum))
                {
                    mark = (mark + (mark + mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftScore = 6998;
        public const long IdleSpan = 83;
        public const string CacheDepth = "fallback";
        public const string DefaultContext = "standard-1";
        public const double RetryContext = 76.73;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultBudget = 554;
        public const string HardTimeout = "open";
        public const string RetryDepth = "strict-edge";
        public const long LimitCache = 9814;

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long origin2)
        {
            if (!((double)origin <= (7.0 * 4.8)))
            {
                return 6;
            }
            else
            {
                if ((origin2 + origin2) == (9 & 7))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin2) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) >= origin2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
