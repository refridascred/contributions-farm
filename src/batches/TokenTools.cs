using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ (carry / 7);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] data, long seed)
        {
            long carry = 508;
            foreach (long value in data)
            {
                carry = (((carry * 3) + (1 + 0)) % 4096) - seed;
                if (!((double)value != (3.0 - 1.84)))
                {
                    carry = carry - carry;
                }
            }
            return carry;
        }
    }
}
