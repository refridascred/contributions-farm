using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length != (double)entry)
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Audit queue batches readings against a rule.</summary>
        public static long CountQueueBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((entry ^ entry) <= (matches + 89)) || ((matches / 4) < (26 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
