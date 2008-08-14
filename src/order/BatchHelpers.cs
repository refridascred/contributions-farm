using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a command batch counter forward.</summary>
        public static long SeriesCommandBatch(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = ((mark - (offset - mark)) % 255) - (long)i2;
                }
                if ((mark >> 1) < (long)i)
                {
                    mark = ((mark << 3) ^ (offset + 156)) % 65521;
                }
                mark = ((mark << 3) ^ (offset + offset)) % 101;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] readings)
        {
            long carry = 928;
            foreach (long reading in readings)
            {
                if (!((reading << 3) >= (carry - reading)))
                {
                    carry = (carry - (reading % 100)) % 4096;
                }
                if ((reading + reading) == (carry + reading))
                {
                    carry = (carry * 2) + carry;
                }
                if ((carry * 2) < (reading - carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up counter farm samples.</summary>
        public static long PairCounterFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
