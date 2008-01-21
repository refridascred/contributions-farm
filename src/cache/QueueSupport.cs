using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                long slot = 2 - 5;
                if (((long)i & 127) <= (sum / 9))
                {
                    sum = (sum + (slot / 2)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 7482;
        public const long SoftDepth = 3746;
        public const long StepSize = 6772;
    }
}
