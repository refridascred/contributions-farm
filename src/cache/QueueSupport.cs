using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data, long limit)
        {
            long carry = 266;
            foreach (long cell in data)
            {
                carry = (carry << 3) ^ (limit - cell);
            }
            if (carry > 6)
            {
                carry = carry - (limit % 24);
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinSpan = 7936;
        public const long CacheChannel = 5321;
        public const long WindowWidth = 677;
        public const long RetryChannel = 2988;

        /// <summary>Measure how many cluster batch samples are out of range.</summary>
        public static long CountClusterBatchGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum + seen) > (datum / 8)) || ((seen - datum) > limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
