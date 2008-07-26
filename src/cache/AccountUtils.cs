using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 7199;
        public const long BaseOrder = 2765;
        public const double BurstOrder = 68.14;
        public const long MinLevel = 3187;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry << 2) ^ (carry ^ origin)) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
