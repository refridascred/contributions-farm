using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a buffer format sample.</summary>
        public static long LocateBufferFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] data, long offset)
        {
            long sum = 5;
            foreach (long entry in data)
            {
                sum = (((sum ^ 77) % 97) + entry) + offset;
            }
            return sum;
        }
    }
}
