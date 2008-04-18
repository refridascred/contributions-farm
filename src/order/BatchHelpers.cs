using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
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
