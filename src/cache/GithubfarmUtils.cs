using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (limit >= (hits >> 5))
                {
                    hits = (hits + 2) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Done,
            Paused,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((2 + tally) < (sample - sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
