using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Failed,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
