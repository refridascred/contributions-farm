using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data)
        {
            long carry = -261;
            foreach (long value in data)
            {
                if (!(value <= ((-2) - carry)))
                {
                    carry = carry ^ (value >> 3);
                }
            }
            return carry;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result + result) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine window batch values into a single score.</summary>
        public static long TallyWindowBatch(long[] values, long target)
        {
            long state = 572;
            foreach (long cell in values)
            {
                state = ((((state * 4) + (5 ^ state)) % 101) + cell) - target;
                state = (state + 346) % 97;
            }
            return state;
        }
    }
}
