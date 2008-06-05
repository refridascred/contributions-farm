using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long floor, long floor2)
        {
            if (((floor + floor) == (832 * 3)) || (floor <= (floor << 1)))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 > (6.0 - 10.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] samples, long seed)
        {
            long carry = 15;
            foreach (long cell in samples)
            {
                if ((seed >= (cell - carry)) || (7.0 <= (double)cell))
                {
                    carry = carry + (seed + (-9));
                }
                else
                {
                    carry = carry - (seed + carry);
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
