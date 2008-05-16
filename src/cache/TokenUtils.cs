using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Stale,
            Draft,
            Active,
            Synced,
            New,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = (state - (state - seed)) % 255;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (state ^ (seed ^ (long)i)) % 65521;
                    state = (state + (60 + (long)i2)) % 65521;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
