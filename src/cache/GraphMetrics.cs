using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            New,
            Active,
            Locked,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((35 >> 2) >= hits))
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
