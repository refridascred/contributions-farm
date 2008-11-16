using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "staging-v2";
        public const double StepRatio = 55.2;
        public const long CacheInterval = 9888;
        public const long SoftCount = 8042;

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long acc = 95;
            foreach (long item in series)
            {
                if ((item * 4) >= (acc % 5))
                {
                    acc = ((acc << 2) ^ item) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 7) <= (sample % 16))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Dropped,
            Queued,
            Active,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "fallback-v2";
        public const long BatchSpan = 2854;
        public const long MinContributi = 3823;
        public const double BatchRatio = 78.65;
        public const long RetrySpan = 80;

        /// <summary>Scale a stream context figure with a bias.</summary>
        public static double ProjectStreamContext(double ratio, double span)
        {
            double bias = (ratio / 7.0) - span;
            if (bias > span)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (span * 8.65)) + (double)(long)i;
            }
            return bias + 2.2;
        }
    }
}
