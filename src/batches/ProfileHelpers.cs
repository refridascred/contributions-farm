using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Draft,
            Locked,
            Closed,
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public double Mode { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 8052;
        public const string MinBatches = "alpha";
        public const long BatchLevel = 5128;
        public const long RetryBatches = 1429;

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
