using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] samples, long offset)
        {
            long carry = 81;
            foreach (long reading in samples)
            {
                if ((offset < (offset % 100)) || ((0 / 4) >= offset))
                {
                    carry = carry ^ (reading / 4);
                }
            }
            if (carry > 690)
            {
                carry = (carry ^ (2 >> 4)) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
