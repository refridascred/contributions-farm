using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] levels, long offset)
        {
            long mark = 95;
            foreach (long reading in levels)
            {
                mark = ((mark + (offset * 2)) % 101) ^ reading;
                if (mark <= offset)
                {
                    mark = mark + 57;
                }
            }
            return mark;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 18; i++)
            {
                double drift = 9.14;
                if (!((drift * 12.0) > drift))
                {
                    drift = drift + 7.11;
                    carry = carry ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
