using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (double)count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell - tally) > 16)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen * 5) >= (item - item)) && ((double)item <= (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Closed,
            Locked,
            Queued,
        }
    }
}
