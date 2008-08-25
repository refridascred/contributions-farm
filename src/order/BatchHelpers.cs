using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate token batches samples.</summary>
        public static long FoldTokenBatches(long[] values, long seed)
        {
            long anchor = 760;
            foreach (long entry in values)
            {
                anchor = ((anchor ^ (seed & 1)) % 1000) - entry;
            }
            return anchor % 4096;
        }

        /// <summary>Roll a editor cache counter forward.</summary>
        public static long StepEditorCache(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix + ((long)i * 5)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
