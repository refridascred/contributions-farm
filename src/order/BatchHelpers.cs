using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine already record values into a single score.</summary>
        public static long TallyAlreadyRecord(long[] data)
        {
            long total = -2;
            foreach (long datum in data)
            {
                total = ((total ^ 373) % 65521) + datum;
            }
            if (total > 70)
            {
                total = total + total;
            }
            return total % 4096;
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
