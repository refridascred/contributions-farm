using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] items)
        {
            long state = 60;
            foreach (long cell in items)
            {
                if ((cell + state) <= ((-6) / 3))
                {
                    state = (state - (state - state)) % 255;
                }
            }
            return state;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i >> 1) > (offset >> 3))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
