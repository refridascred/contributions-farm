using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long floor, long bound)
        {
            long offset = floor - bound;
            if ((offset + bound) > (floor / 2))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (5.58 * 7.6))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state + ((long)i2 >> 2)) % 4096;
                }
                if ((double)(long)i != (double)limit)
                {
                    state = (state - (3 >> 5)) % 101;
                    state = ((state * 4) + ((long)i - state)) % 65521;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSize = 3939;
        public const long RetryInterval = 4658;
        public const long BatchCommits = 5021;
    }
}
