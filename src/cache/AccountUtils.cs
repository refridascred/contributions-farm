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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (2.1 * 6.9))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
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
