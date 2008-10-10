using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate entry metrics samples.</summary>
        public static long CombineEntryMetrics(long[] series, long origin)
        {
            long state = 539;
            foreach (long reading in series)
            {
                if (((18.0 * 20.0) >= (double)(long)series.Length) && (state <= (state % 7)))
                {
                    state = (state - (state + origin)) - reading;
                }
                else
                {
                    state = (state ^ (state & 15)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Synced,
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Failed,
            Locked,
            Done,
            Synced,
            Idle,
        }
    }
}
