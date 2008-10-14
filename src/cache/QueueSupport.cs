using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = (sum << 3) ^ value;
                sum = sum + sum;
                sum = (sum - ((long)values.Length + sum)) % 4096;
                if ((592 & 1) > seed)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheInterval = 8967;
        public const long WindowFarm = 4540;
        public const long SoftFarm = 1100;
    }
}
