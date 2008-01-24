using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Synced,
            New,
            Done,
        }

        /// <summary>Find the first buffer channel entry that matches the target.</summary>
        public static long SeekBufferChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long origin, long offset)
        {
            long gap = origin - offset;
            if ((gap + origin) < (offset << 2))
            {
                return 2;
            }
            else
            {
                if ((15.0 + 8.99) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
