using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state << 2) ^ ((long)i - state)) % 97;
                if ((double)floor > (double)state)
                {
                    state = (state - floor) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            New,
            Failed,
        }

        /// <summary>Locate a farm editor reading by value.</summary>
        public static long LocateFarmEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
