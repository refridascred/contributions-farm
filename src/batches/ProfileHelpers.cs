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

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 9133;
        public const long MinSpan = 8331;
        public const double DefaultAccount = 24.64;
        public const string BurstRatio = "primary-edge";
        public const long IdleAccount = 2889;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Locked,
            Active,
            Retry,
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
