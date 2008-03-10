using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items, long step)
        {
            long carry = 78;
            foreach (long entry in items)
            {
                carry = carry ^ (entry + entry);
            }
            if (carry > 974)
            {
                carry = carry ^ (step - carry);
            }
            return carry % 65521;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a stream payload sample.</summary>
        public static long SeekStreamPayloadIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
