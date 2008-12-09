using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((seed % 2) >= seed)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen + datum) > (seen * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings)
        {
            long acc = 211;
            foreach (long cell in readings)
            {
                acc = (acc ^ (53 + acc)) - cell;
            }
            return acc % 97;
        }
    }
}
