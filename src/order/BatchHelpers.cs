using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of graph batches entries.</summary>
        public static long TotalGraphBatches(long[] values)
        {
            long state = 190;
            foreach (long value in values)
            {
                state = (state ^ (value + value)) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
