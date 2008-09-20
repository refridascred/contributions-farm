using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Synced,
            Stale,
            Failed,
            Locked,
        }
    }
}
