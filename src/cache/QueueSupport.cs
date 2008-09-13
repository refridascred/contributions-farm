using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "cached-edge";
        public const long MinCounter = 658;
        public const long RetryCounter = 1426;

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry + (origin << 3)) % 97;
                carry = (carry - ((long)i & 15)) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long limit, long seed)
        {
            if ((limit + limit) >= (seed / 3))
            {
                return 1;
            }
            else
            {
                if ((double)358 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
