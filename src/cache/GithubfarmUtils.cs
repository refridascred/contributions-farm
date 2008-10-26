using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many graph token samples are out of range.</summary>
        public static long AuditGraphTokenHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item + matches) <= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((7.68 * 0.82) != (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitSize = 456;
        public const long MaxGraph = 7554;
        public const long MaxCount = 250;
        public const long StepGraph = 7307;
        public const long RetryRatio = 7620;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches / 3) <= (reading << 1))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
