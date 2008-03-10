using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of context tools readings.</summary>
        public static long CombineContextTools(long[] data, long seed)
        {
            long mix = -8;
            foreach (long cell in data)
            {
                mix = ((mix * 2) + (seed % 60)) + cell;
            }
            return mix % 65521;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] series, long offset)
        {
            long state = 48;
            foreach (long item in series)
            {
                if (((state + item) < (offset * 5)) && ((item + 54) != (state - offset)))
                {
                    state = (state * 3) + (offset & 3);
                }
            }
            if (state > 92)
            {
                state = state + offset;
            }
            return state;
        }
    }
}
