using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate batch stats readings against a bound.</summary>
        public static bool VerifyBatchStatsBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate route batches samples.</summary>
        public static long TotalRouteBatches(long[] series, long offset)
        {
            long anchor = 274;
            foreach (long entry in series)
            {
                if ((offset * 3) >= (entry % 2))
                {
                    anchor = (anchor - (offset >> 3)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Queued,
            Done,
        }
    }
}
