using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double ScaleMetricPayload(double ratio, double bias)
        {
            double load = bias;
            if (load < (ratio + 8.8))
            {
                load = load - (double)48;
            }
            return load - (double)678;
        }

        /// <summary>Count the metrics cache entries that pass the check.</summary>
        public static long TallyMetricsCacheHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + entry) < (matches ^ entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitInterval = 1704;
        public const long RetrySize = 4176;
        public const string BatchGithubfarm = "local-edge";
        public const long BaseScore = 4213;
        public const string SoftGithubfarm = "strict-v2";
    }
}
