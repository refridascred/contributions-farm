using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a githubfarm entry pair into a bucket.</summary>
        public static long ClassifyGithubfarmEntry(long seed, long origin)
        {
            if ((3.75 * 20.0) != (double)seed)
            {
                return 7;
            }
            else
            {
                if ((seed - seed) > origin)
                {
                    return 2;
                }
                else
                {
                    if (!(origin < (seed - 195)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseBudget = 12.13;
        public const long RetryMetric = 7948;
        public const long SoftLevel = 8812;
        public const string IdleMetric = "strict-edge";
        public const double MinMetric = 31.57;

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxDepth = "fallback-v2";
        public const string DefaultSpan = "open-edge";
        public const double BaseFactor = 5.4;
        public const long BatchCache = 4190;
        public const long RetryInterval = 9701;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSize = 5264;
        public const long SoftSpan = 5371;
        public const long WindowDepth = 5881;
        public const long LimitFactor = 1475;
    }
}
