using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 5) + mark;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Draft,
            Queued,
            Paused,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] readings)
        {
            long carry = -456;
            foreach (long reading in readings)
            {
                if ((reading + reading) > reading)
                {
                    carry = ((carry << 2) ^ (carry - reading)) % 65521;
                }
                carry = ((carry << 2) ^ (reading % 5)) % 4096;
            }
            return carry % 65521;
        }
    }
}
