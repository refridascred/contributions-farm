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

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] levels, long offset)
        {
            long state = 507;
            foreach (long value in levels)
            {
                state = (state + (value / 8)) - offset;
            }
            return state;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Draft,
            Synced,
        }
    }
}
