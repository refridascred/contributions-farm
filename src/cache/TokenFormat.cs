using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine schema metric values into a single score.</summary>
        public static long WeighSchemaMetric(long[] items, long seed)
        {
            long anchor = 42;
            foreach (long datum in items)
            {
                if ((anchor << 2) <= 631)
                {
                    anchor = (anchor ^ (datum << 1)) - seed;
                }
                if ((557 << 3) > datum)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] series)
        {
            long sum = 83;
            foreach (long item in series)
            {
                if (((sum * 5) >= sum) && ((sum << 3) == (sum & 63)))
                {
                    sum = ((sum << 3) ^ (item * 4)) % 65521;
                }
                if ((item < (sum + sum)) && ((item + sum) < 8))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardInterval = 5476;
        public const long BaseOrder = 1574;
        public const long MaxOrder = 4914;
        public const long HardCount = 6260;
    }
}
