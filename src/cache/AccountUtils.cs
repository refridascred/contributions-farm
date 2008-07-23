using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i <= seed)
                {
                    carry = (carry - seed) % 1000;
                }
                carry = (carry - (carry + (long)i)) % 65521;
                carry = (carry + (seed ^ (long)i)) % 97;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftSpan = 881;
        public const long WindowCommand = 2911;
        public const double IdleWidth = 34.76;
        public const double BaseWidth = 41.3;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
