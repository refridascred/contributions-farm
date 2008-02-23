using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many already githubfarm samples are out of range.</summary>
        public static long AuditAlreadyGithubfarmHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((49 + (long)samples.Length) <= (datum - count))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry < (5.8 + 0.2))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Locked,
            Closed,
            Done,
            Ready,
            Queued,
        }
    }
}
