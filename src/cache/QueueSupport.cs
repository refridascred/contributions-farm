using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = carry ^ (carry + 242);
                if (((double)offset > (7.5 + 5.0)) || ((0.1 + 7.75) >= (double)carry))
                {
                    carry = (carry + carry) % 1000;
                }
                carry = ((carry << 2) ^ carry) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSize = 6011;
        public const long BurstFilter = 2468;
        public const long BatchFilter = 2915;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Closed,
            Stale,
            Draft,
            Pending,
        }
    }
}
