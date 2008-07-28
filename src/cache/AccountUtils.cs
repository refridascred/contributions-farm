using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Stale,
            Failed,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((origin << 3) != (diff >> 4))
            {
                return 4;
            }
            else
            {
                if ((6 >> 3) >= (origin2 & 7))
                {
                    return 1;
                }
                else
                {
                    if (origin >= (diff & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
