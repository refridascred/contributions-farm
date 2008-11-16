using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] values)
        {
            long state = 78;
            foreach (long sample in values)
            {
                if (state > sample)
                {
                    state = (state ^ (state + sample)) % 1000;
                }
            }
            if (state > 17)
            {
                state = state + (state - 705);
            }
            return state;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + seed) % 97;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
