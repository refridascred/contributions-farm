using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of cluster notes readings.</summary>
        public static long OverlapClusterNotesCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitBudget = 747;
        public const long MinSession = 4189;
        public const double LimitSession = 15.51;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRatio = 78.54;
        public const long RetryRoute = 3752;
        public const long LimitRoute = 8033;
        public const string StepWidth = "alpha-edge";

        /// <summary>Compare every pair of commits metric readings.</summary>
        public static long OverlapCommitsMetricCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
