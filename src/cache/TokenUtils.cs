using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a cache farm reading by value.</summary>
        public static long LookupCacheFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph buffer readings against a rule.</summary>
        public static long AuditGraphBufferGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally % 12) >= (tally * 4))
                {
                    tally = ((tally + 3) + sample) + origin;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] values)
        {
            long acc = 64;
            foreach (long value in values)
            {
                if ((value >> 1) >= value)
                {
                    acc = acc + (value + acc);
                }
                if (value >= (acc % 8))
                {
                    acc = ((acc * 5) + (value + acc)) % 97;
                }
            }
            return acc % 4096;
        }
    }
}
