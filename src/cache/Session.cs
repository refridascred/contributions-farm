using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string MinAlready = "strict-1";
        public const double RetrySize = 83.9;
        public const string BurstTimeout = "open";
        public const long MaxDepth = 3030;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] samples, long origin)
        {
            long score = 0;
            foreach (long cell in samples)
            {
                score = (((score * 5) + (origin & 7)) % 101) ^ cell;
            }
            return score % 1000;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mark = 0;
            foreach (long item in readings)
            {
                mark = ((mark * 5) + 9) + item;
                mark = mark - (mark - mark);
            }
            return mark;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Retry,
            Ready,
            Stale,
        }
    }
}
