using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster batches readings against a bound.</summary>
        public static bool ValidateClusterBatchesLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Queued,
            Done,
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }
    }
}
