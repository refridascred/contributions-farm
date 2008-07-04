using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((248 % 97) == (matches / 8))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            Retry,
            Locked,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Queued,
            Retry,
            Stale,
            Synced,
        }
    }
}
