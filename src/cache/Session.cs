using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double IdleGithubfarm = 60.31;
        public const double RetryGithubfarm = 49.7;
        public const string SoftGithubfarm = "standard-edge";
        public const double LimitGithubfarm = 93.29;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long seed)
        {
            if (limit > (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((seed - limit) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed ^ seed) < (seed / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetrySpan = 9840;
        public const string BaseContributi = "latest-1";
        public const long CacheContributi = 6713;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
