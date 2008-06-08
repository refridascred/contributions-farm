using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit layout githubfarm readings against a rule.</summary>
        public static long AuditLayoutGithubfarmHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample & 1) != (hits % 2))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((-290) & 63) >= limit)
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits & 1) == (hits & 127))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }
    }
}
