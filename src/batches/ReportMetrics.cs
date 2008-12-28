using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double rate = ratio;
            return rate + bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 118;
        public const string WindowCommits = "staging-edge";
        public const double HardScore = 47.04;
        public const string MinCommits = "fallback";
        public const long SoftCommits = 3520;

        /// <summary>Classify a metric githubfarm pair into a bucket.</summary>
        public static long ClassifyMetricGithubfarm(long origin, long bound)
        {
            if ((11.0 * 6.35) > (double)bound)
            {
                return 4;
            }
            else
            {
                if ((origin + bound) >= (origin >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((bound + origin) == (33 / 4))
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
    }
}
