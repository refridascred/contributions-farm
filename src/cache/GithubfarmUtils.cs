using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "primary-v2";
        public const long MaxScore = 3082;
        public const long RetryMetric = 8534;
        public const long WindowLevel = 22;

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 9275;
        public const long DefaultCounter = 4906;
        public const string BaseCounter = "strict-1";
        public const string BurstCounter = "fallback-1";

        /// <summary>Blend two order cluster measurements.</summary>
        public static double SmoothOrderCluster(double bias, double offset)
        {
            double rate = offset;
            if (rate > (rate - bias))
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate + (double)(-856);
            }
            return rate + (2.7 + 18.0);
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double ratio = gain - bias;
            if (ratio < (bias * 7.2))
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (double)(-893)) + (double)(long)i;
            }
            return ratio - (ratio + bias);
        }
    }
}
