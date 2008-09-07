using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long StepDepth = 3424;
        public const long HardRoute = 6550;
        public const long StepTimeout = 8126;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a format tools pair into a bucket.</summary>
        public static long GradeFormatTools(long seed, long bound)
        {
            if (!((6.95 / 2.0) == (double)bound))
            {
                return 6;
            }
            else
            {
                if (bound < seed)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
