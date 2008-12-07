using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Stale,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count - value) >= (value - (long)data.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
