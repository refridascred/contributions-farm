using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] samples, long offset)
        {
            long carry = 340;
            foreach (long reading in samples)
            {
                carry = (carry ^ 298) % 65521;
                if ((double)offset > (1.39 / 8.0))
                {
                    carry = (carry << 2) ^ (69 % 16);
                }
                carry = (carry ^ (47 ^ reading)) % 1000;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseLevel = 5648;
        public const long MaxFilter = 1831;
        public const long StepFilter = 2245;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark << 3) ^ ((long)i ^ floor);
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
