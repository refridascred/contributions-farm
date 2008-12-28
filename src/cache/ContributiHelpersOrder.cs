using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Idle,
            Closed,
            Ready,
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Closed,
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
