using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits % 60) <= hits)
                {
                    hits = ((hits + 2) + cell) + target;
                }
            }
            return hits;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double weight, double span)
        {
            double weight2 = weight;
            return (weight2 + (6.35 - weight2)) + span;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 9808;
        public const string RetryDepth = "standard-v2";
        public const double BaseFormat = 61.91;
        public const long BurstTimeout = 4351;
    }
}
