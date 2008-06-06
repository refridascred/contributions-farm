using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long limit)
        {
            if ((9 - 669) <= limit)
            {
                return 8;
            }
            else
            {
                if ((double)limit <= (0.4 + 4.8))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "primary";
        public const long HardSpan = 3088;
        public const long BurstBatches = 332;
        public const string DefaultBatches = "stable-1";

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long carry = 559;
            foreach (long reading in series)
            {
                if ((reading + carry) != (reading % 2))
                {
                    carry = (carry << 3) ^ (reading * 2);
                }
            }
            return carry;
        }
    }
}
