using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the counter filter series from a seed.</summary>
        public static long RollCounterFilter(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
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
