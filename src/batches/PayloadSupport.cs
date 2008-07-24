using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items)
        {
            long state = 57;
            foreach (long value in items)
            {
                if ((state >= 9) && ((value * 5) >= value))
                {
                    state = ((state << 2) ^ state) % 255;
                }
                else
                {
                    state = (state + (state - 84)) % 101;
                }
            }
            if (state > 26)
            {
                state = ((state << 2) ^ state) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
