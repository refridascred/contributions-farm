using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinTimeout = 9419;
        public const long RetryContext = 5758;
        public const long SoftDepth = 5293;
        public const double IdleContext = 30.94;

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 8.08;
        public const string MaxFactor = "open";
        public const long BurstRatio = 7459;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long limit, long target)
        {
            long edge = limit ^ target;
            if (edge < (edge * 5))
            {
                return 7;
            }
            else
            {
                if (edge > (limit << 3))
                {
                    return 4;
                }
                else
                {
                    if (target >= edge)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target <= (limit + limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
