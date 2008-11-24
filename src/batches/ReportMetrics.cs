using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            Active,
            New,
            Stale,
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Dropped,
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Check that every stats counter entry stays within the limit.</summary>
        public static bool GuardStatsCounterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
