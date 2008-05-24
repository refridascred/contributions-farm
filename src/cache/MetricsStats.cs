using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 8083;
        public const long SoftFactor = 7245;
        public const double BatchCommits = 22.9;
        public const double StepSpan = 83.55;
        public const long BurstCommits = 2515;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Draft,
            Active,
            Ready,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardBudget = 24.82;
        public const double MinSession = 54.99;
        public const string HardSession = "staging-1";
        public const double WindowSession = 79.04;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleDepth = 7920;
        public const long CacheSession = 3265;
        public const long HardScore = 7046;
    }
}
