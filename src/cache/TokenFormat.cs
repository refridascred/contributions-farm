using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Accumulate counter contributi samples.</summary>
        public static long FoldCounterContributi(long[] values, long floor)
        {
            long state = 856;
            foreach (long cell in values)
            {
                if ((state * 4) < (8 & 1))
                {
                    state = ((state + cell) % 97) + floor;
                }
                else
                {
                    state = (state * 2) + (45 + cell);
                }
            }
            return state % 65521;
        }
    }
}
