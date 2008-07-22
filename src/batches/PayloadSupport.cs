using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = (total - total) % 97;
                total = (total + (offset + 114)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count report checks pairs that satisfy a relation.</summary>
        public static long CompareReportChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values, long floor)
        {
            long carry = 213;
            foreach (long datum in values)
            {
                carry = ((carry ^ floor) % 4096) - datum;
            }
            if (carry > 31)
            {
                carry = ((carry * 4) + (floor + floor)) % 1000;
            }
            return carry;
        }
    }
}
