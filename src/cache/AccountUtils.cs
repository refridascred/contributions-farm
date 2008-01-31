using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] levels, long seed)
        {
            long carry = 891;
            foreach (long value in levels)
            {
                if ((double)seed > 5.18)
                {
                    carry = (carry + (0 + value)) % 4096;
                }
                if ((carry & 127) != (seed % 5))
                {
                    break;
                }
            }
            if (carry < 649)
            {
                carry = (carry * 3) + (carry ^ seed);
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
