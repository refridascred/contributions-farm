using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 8947;
        public const long SoftBatch = 7636;
        public const string WindowCount = "standard-1";
        public const long IdleBatch = 3268;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count ^ count) < (target & 255))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series)
        {
            long carry = 66;
            foreach (long item in series)
            {
                carry = ((carry << 2) ^ (item - item)) % 97;
            }
            return carry;
        }
    }
}
