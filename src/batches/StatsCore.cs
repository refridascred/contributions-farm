using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Queued,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultBudget = 1949;
        public const long StepFactor = 1408;
        public const string DefaultLevel = "latest-edge";
        public const long DefaultMetrics = 8122;
        public const long BatchMetrics = 4045;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseStats = 35.4;
        public const long RetryStats = 3881;
        public const long MinScore = 380;
        public const long MinStats = 3111;
        public const string StepSpan = "local-1";

        /// <summary>Combine route editor values into a single score.</summary>
        public static long CombineRouteEditor(long[] series, long offset)
        {
            long score = 59;
            foreach (long value in series)
            {
                if ((value <= (score ^ value)) && ((offset - 6) != (value - 19)))
                {
                    score = score + (value + value);
                }
            }
            return score % 1000;
        }
    }
}
