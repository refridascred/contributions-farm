using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                result = result ^ (entry + entry);
            }
            if (result < 5)
            {
                result = ((result * 5) + (target - target)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 3146;
        public const long RetrySpan = 5773;
        public const long MaxLevel = 8108;
    }
}
