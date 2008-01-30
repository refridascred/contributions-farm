using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate counter account samples.</summary>
        public static long TotalCounterAccount(long[] readings)
        {
            long carry = 436;
            foreach (long datum in readings)
            {
                if ((carry < (1 ^ carry)) || ((425 >> 4) < (carry + carry)))
                {
                    carry = (carry ^ (datum + datum)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry - 5)) % 4096;
                }
            }
            if (carry > 191)
            {
                carry = carry - (37 / 8);
            }
            return carry;
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
