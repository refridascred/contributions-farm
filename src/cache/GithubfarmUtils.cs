using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (8.5 - 2.09))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Draft,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((target << 2) == (long)levels.Length)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double rate, double span)
        {
            double drift = span;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - rate;
            }
            return drift + 3.3;
        }
    }
}
