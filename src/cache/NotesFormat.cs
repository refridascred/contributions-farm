using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)origin < (1.0 + 13.0))
                {
                    carry = (carry + (long)i) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 1000;
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
