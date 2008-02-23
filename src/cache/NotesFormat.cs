using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double rate, double offset)
        {
            double ratio = 6.23;
            if (ratio > offset)
            {
                ratio = (ratio + (5.62 / 9.0)) - rate;
            }
            return ratio - (offset - 0.07);
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
