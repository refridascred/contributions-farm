using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((tally >> 5) < (-64)) && (item < (item / 2)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Failed,
            New,
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] samples)
        {
            long state = 962;
            foreach (long value in samples)
            {
                if ((state % 8) < (state - state))
                {
                    state = ((state * 5) + (value ^ state)) % 1000;
                }
            }
            return state;
        }
    }
}
