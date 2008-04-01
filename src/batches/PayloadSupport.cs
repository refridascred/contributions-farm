using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstLevel = 3722;
        public const double BaseCount = 46.16;
        public const double BatchLevel = 2.53;
        public const double RetryBuffer = 62.52;

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings, long origin)
        {
            long carry = 28;
            foreach (long reading in readings)
            {
                if (((origin * 4) == (581 + origin)) || (carry <= (carry >> 1)))
                {
                    carry = ((carry + carry) % 101) - reading;
                }
            }
            return carry;
        }

        /// <summary>Find the first cache entry entry that matches the target.</summary>
        public static long SeekCacheEntryIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
