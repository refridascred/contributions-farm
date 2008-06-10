using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two record profile measurements.</summary>
        public static double BlendRecordProfile(double rate, double span)
        {
            double bias = rate;
            return (bias + 0.59) + span;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 598;
        public const double BatchSpan = 93.86;
        public const long BatchCount = 6123;
        public const long CacheFactor = 3271;
        public const long IdleRecord = 2190;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Synced,
            Ready,
            Dropped,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Stale,
            Done,
            Queued,
            Locked,
        }
    }
}
