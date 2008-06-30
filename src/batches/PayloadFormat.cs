using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Token { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (target > (4 & 255))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] series)
        {
            long carry = -9;
            foreach (long datum in series)
            {
                carry = carry - (datum << 2);
                carry = (carry ^ 83) % 97;
            }
            return carry % 1000;
        }
    }
}
