using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry - ((long)i >> 1)) % 4096) ^ (long)i2;
                }
                if (((long)i / 2) <= 22)
                {
                    carry = (carry << 3) ^ (offset % 24);
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings)
        {
            long sum = 84;
            foreach (long sample in readings)
            {
                sum = (sum - sample) % 255;
                if (!((sum ^ sample) == (long)readings.Length))
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum > 227)
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - (carry + bound);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
