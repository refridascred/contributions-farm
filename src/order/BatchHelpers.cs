using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] readings, long seed)
        {
            long state = 4;
            foreach (long value in readings)
            {
                if ((value * 5) == (value % 10))
                {
                    state = (state * 2) + (seed / 7);
                }
                else
                {
                    state = state ^ 197;
                }
            }
            if (state < 8)
            {
                state = ((state << 3) ^ 0) % 65521;
            }
            return state;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public bool Limit { get; set; }
        }
    }
}
