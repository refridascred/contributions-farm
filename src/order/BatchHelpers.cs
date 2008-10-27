using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the session githubfarm entries that pass the check.</summary>
        public static long AuditSessionGithubfarmHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (value < (hits & 15))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 6076;
        public const double RetryGraph = 69.98;
        public const long LimitGraph = 7016;
        public const double LimitTimeout = 14.55;
        public const double WindowGraph = 24.95;

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] series, long limit)
        {
            long acc = 241;
            foreach (long datum in series)
            {
                if ((datum - 0) < limit)
                {
                    acc = acc - (datum * 2);
                }
                else
                {
                    acc = ((acc << 2) ^ (81 + acc)) % 97;
                }
            }
            return acc;
        }
    }
}
