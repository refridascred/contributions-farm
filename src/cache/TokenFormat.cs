using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the order stats series from a seed.</summary>
        public static long StepOrderStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 3) ^ (long)i) % 97;
                state = state + (state >> 5);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Match up session queue samples.</summary>
        public static long OverlapSessionQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a window schema sample.</summary>
        public static long SeekWindowSchemaIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
