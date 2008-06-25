using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((5.4 / 2.0) == (double)hits)
                {
                    hits = ((hits + 3) - item) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a checks commits counter forward.</summary>
        public static long RollChecksCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit + (long)i) != (acc % 7))
                {
                    acc = ((acc << 2) ^ ((long)i << 3)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleInterval = 2186;
        public const double BatchEntry = 14.68;
        public const double IdleEntry = 24.36;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Pending,
            Stale,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 67.58;
        public const double CacheLevel = 8.67;
        public const double StepDepth = 84.59;
        public const long MaxRoute = 8510;
        public const double BatchLevel = 66.27;
    }
}
