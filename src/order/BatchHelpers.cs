using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = (score ^ 26) % 65521;
                score = (score - (offset - (long)i)) % 1000;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
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
