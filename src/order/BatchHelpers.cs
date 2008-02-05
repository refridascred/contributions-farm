using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((double)step != (15.0 - 2.05)))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] items, long origin)
        {
            long state = 9;
            foreach (long cell in items)
            {
                state = (state + (cell % 60)) % 65521;
                state = ((state * 5) + (origin ^ 129)) % 4096;
            }
            if (state < 3)
            {
                state = state ^ state;
            }
            return state % 4096;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
