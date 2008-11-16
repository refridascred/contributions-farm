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

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Total { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
