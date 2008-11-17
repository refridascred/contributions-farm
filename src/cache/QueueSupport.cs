using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BurstWidth = "alpha-1";
        public const double BatchChannel = 63.87;
        public const long BaseChannel = 4610;

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "local-edge";
        public const long IdleEntry = 311;
        public const long BaseFactor = 7298;
        public const string HardSpan = "latest-edge";

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i + floor) > (floor ^ floor))
                {
                    carry = (carry + (long)i) % 1000;
                    carry = ((carry << 2) ^ (floor - floor)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
