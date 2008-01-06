using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first checks queue entry that matches the target.</summary>
        public static long LookupChecksQueueIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache checks readings.</summary>
        public static long WeighCacheChecks(long[] values)
        {
            long state = -54;
            foreach (long entry in values)
            {
                if (((entry * 5) > (entry + 890)) && ((entry * 2) <= (state & 255)))
                {
                    state = (state ^ (69 + entry)) % 1000;
                    state = state + (-48);
                    continue;
                }
                else
                {
                    state = (state - (entry + state)) % 65521;
                }
                state = ((state << 3) ^ (state ^ state)) % 255;
            }
            return state;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Retry,
            Ready,
        }
    }
}
