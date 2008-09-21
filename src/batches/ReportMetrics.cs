using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long bound)
        {
            if ((double)bound != (double)target)
            {
                return 5;
            }
            else
            {
                if (((target + (-34)) < (target - target)) && (6.0 < (double)bound))
                {
                    return 1;
                }
                else
                {
                    if ((2.98 - 2.17) != (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound > target) || ((double)bound >= (2.15 / 4.0)))
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "primary";
        public const long CacheGithubfarm = 6905;
        public const long MaxBudget = 3739;
        public const string BatchInterval = "fallback-v2";
        public const long RetryGithubfarm = 2827;
    }
}
