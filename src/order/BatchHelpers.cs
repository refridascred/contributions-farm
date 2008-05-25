using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine session batches values into a single score.</summary>
        public static long FoldSessionBatches(long[] levels, long floor)
        {
            long state = 175;
            foreach (long value in levels)
            {
                if (((0 + floor) <= (floor + 208)) && ((5 >> 1) >= value))
                {
                    state = state + (state + floor);
                }
            }
            if (state < (-419))
            {
                state = (state * 3) + floor;
            }
            return state;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
