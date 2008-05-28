using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Active,
            Pending,
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Done,
            Synced,
            Paused,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Idle,
            Stale,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 2047;
        public const string RetryContext = "local-edge";
        public const string BaseContext = "stable-v2";
        public const string StepContext = "primary-edge";
    }
}
