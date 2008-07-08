using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a githubfarm metric reading.</summary>
        public static double SmoothGithubfarmMetric(double bias, double bias2)
        {
            double drift = bias - bias;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + (double)5) - (double)(long)i) - bias2;
            }
            return drift - (bias - bias);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 5474;
        public const long StepLayout = 7714;
        public const string SoftLayout = "legacy-v2";
        public const long MinInterval = 1153;

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 8621;
        public const string MaxCache = "latest";
        public const long WindowCache = 8029;
        public const long HardRatio = 8281;
        public const long MinCache = 7104;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Ready,
            Stale,
        }
    }
}
