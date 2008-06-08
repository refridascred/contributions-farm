using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitDepth = 26.56;
        public const string LimitStats = "primary";
        public const long SoftLevel = 2473;
        public const long HardWidth = 4876;
        public const double WindowStats = 8.37;

        /// <summary>Adjust a token githubfarm reading.</summary>
        public static double BlendTokenGithubfarm(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (double)72)
            {
                ratio = (ratio - (double)(-5)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseInterval = "open";
        public const string BatchFactor = "legacy-v2";
        public const long SoftFactor = 7837;
        public const double MaxCache = 24.21;
    }
}
