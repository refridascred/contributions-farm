using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] samples)
        {
            long carry = -53;
            foreach (long cell in samples)
            {
                if ((cell & 63) > (carry - cell))
                {
                    carry = ((carry << 3) ^ ((long)samples.Length ^ cell)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + mix) <= mix)
                {
                    mix = (mix << 3) ^ (long)i;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
