using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryScore = 2611;
        public const double SoftCounter = 29.13;
        public const long WindowBudget = 9699;
        public const long RetrySize = 3330;

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "fallback-v2";
        public const long CacheScore = 2814;
        public const long StepInterval = 5002;
        public const long BaseSize = 4433;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
