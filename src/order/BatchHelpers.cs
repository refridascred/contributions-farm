using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowInterval = 85.61;
        public const long MaxTimeout = 9993;
        public const long RetrySize = 322;
        public const long MaxEditor = 5974;
        public const long MinSpan = 4676;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry << 3) ^ ((long)i + carry);
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long offset, long offset2)
        {
            if (((offset + offset2) < offset2) && ((offset2 + offset) <= offset2))
            {
                return 3;
            }
            else
            {
                if ((offset >= (offset + offset)) || ((-962) >= offset))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
