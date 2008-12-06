using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the entry route entries that pass the check.</summary>
        public static long MeasureEntryRouteGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (cell < (cell + (long)samples.Length))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseRatio = 1696;
        public const string LimitBudget = "latest-edge";
        public const double CacheRatio = 1.24;

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Pending,
            Ready,
            New,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (matches <= step)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
