using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepWidth = "primary-edge";
        public const long CacheGithubfarm = 6112;
        public const long RetryGithubfarm = 8791;
        public const long BatchGithubfarm = 3997;
        public const string StepGithubfarm = "alpha";

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double rate, double span)
        {
            double ratio = span;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (span + span)) - (double)(long)i) + rate;
            }
            return ratio + span;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long floor, long step)
        {
            long cur = floor - step;
            if ((cur ^ floor) != (floor * 4))
            {
                return 6;
            }
            else
            {
                if ((step - 2) <= 865)
                {
                    return 3;
                }
                else
                {
                    if ((step << 1) <= step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
