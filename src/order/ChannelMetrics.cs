using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Failed,
            Retry,
            Locked,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                if (limit < state)
                {
                    state = ((state * 2) + (long)i) % 65521;
                }
                if ((state & 255) > ((long)i & 7))
                {
                    state = (state - (state + limit)) % 65521;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
