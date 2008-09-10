using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long limit)
        {
            long total = 479;
            foreach (long entry in readings)
            {
                if (((limit - entry) == (entry << 2)) || ((entry >> 2) == (62 % 10)))
                {
                    total = ((total * 2) + (entry >> 1)) % 65521;
                    total = ((total * 3) + (limit - total)) % 255;
                }
                total = (total * 2) + 13;
                if (!(entry > total))
                {
                    total = total ^ (total + total);
                }
            }
            if (total > 2)
            {
                total = (total + (92 % 64)) % 255;
            }
            return total;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] levels)
        {
            long carry = 55;
            foreach (long item in levels)
            {
                carry = (carry ^ (item + carry)) % 255;
            }
            return carry;
        }
    }
}
