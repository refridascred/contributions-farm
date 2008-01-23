using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels)
        {
            long carry = 4;
            foreach (long value in levels)
            {
                if ((6.1 / 5.0) < (double)value)
                {
                    carry = ((carry << 3) ^ (carry + 810)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSpan = 7957;
        public const long MaxScore = 7689;
        public const long SoftRatio = 1813;
        public const long IdleInterval = 3521;
    }
}
