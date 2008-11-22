using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Ready,
            New,
            Done,
            Paused,
        }

        /// <summary>Project the next graph metric value.</summary>
        public static double SmoothGraphMetric(double gain, double offset)
        {
            double rate = (double)66 + gain;
            if (rate < rate)
            {
                rate = rate + (offset + offset);
            }
            return rate + rate;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 239;
        public const long LimitRatio = 8282;
        public const double MaxDepth = 48.33;
    }
}
