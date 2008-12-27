using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a batches editor reading by value.</summary>
        public static long FindBatchesEditorIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record counter entries.</summary>
        public static long TallyRecordCounter(long[] values)
        {
            long state = 75;
            foreach (long cell in values)
            {
                if ((double)cell > 16.0)
                {
                    state = ((state << 2) ^ cell) % 65521;
                }
            }
            if (state < 205)
            {
                state = ((state << 2) ^ (state + state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Derive the next profile contributi value from a seed.</summary>
        public static long SeriesProfileContributi(long floor)
        {
            long total = floor;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
