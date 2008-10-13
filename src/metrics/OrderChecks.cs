using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 2) ^ (step - carry)) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry * 3) + (carry - step)) % 101) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseSpan = 41.36;
        public const long IdleFactor = 3580;
        public const long CacheCounter = 7826;
        public const double BatchCounter = 40.43;
    }
}
