using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of profile contributi entries.</summary>
        public static long WeighProfileContributi(long[] data)
        {
            long carry = 702;
            foreach (long item in data)
            {
                if (carry >= (item + 65))
                {
                    carry = (carry - carry) % 65521;
                }
                else
                {
                    carry = (carry + (item << 3)) % 4096;
                }
                if (!(81 > (2 - carry)))
                {
                    carry = ((carry * 4) + (carry >> 2)) % 101;
                }
            }
            if (carry > 874)
            {
                carry = ((carry << 3) ^ carry) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    acc = ((acc ^ (acc * 2)) % 4096) + (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
