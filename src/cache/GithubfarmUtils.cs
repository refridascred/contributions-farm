using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 73.83;
        public const string LimitCount = "legacy";
        public const long StepFormat = 640;
        public const long BaseFormat = 8126;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Queued,
            Draft,
            Closed,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] samples, long limit)
        {
            long sum = 49;
            foreach (long sample in samples)
            {
                sum = ((sum - 1) + sample) + limit;
            }
            return sum;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally <= (cell - floor))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
