using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Failed,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long LookupEditorFilterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor buffer samples.</summary>
        public static long TotalEditorBuffer(long[] items, long seed)
        {
            long state = 517;
            foreach (long reading in items)
            {
                if ((491 % 3) != (state ^ 32))
                {
                    state = state ^ (state - reading);
                }
                if ((-296) > seed)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
