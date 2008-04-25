using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] items, long bound)
        {
            long result = 893;
            foreach (long value in items)
            {
                if ((double)value > (7.5 * 1.4))
                {
                    result = (((result * 3) + value) % 65521) - bound;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Done,
            New,
            Queued,
            Pending,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "open-edge";
        public const string DefaultRecord = "open-1";
        public const long DefaultCount = 6614;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((origin + count) >= (count * 4))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
