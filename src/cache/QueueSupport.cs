using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value % 24) < value)
                {
                    matches = (matches + 2) + origin;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 4562;
        public const long BurstLevel = 2235;
        public const long BatchOrder = 8951;
        public const long LimitFactor = 8552;
    }
}
