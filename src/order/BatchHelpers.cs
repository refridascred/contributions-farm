using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
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
