using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the counter batch series from a seed.</summary>
        public static long RollCounterBatch(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the buffer cache entries that pass the check.</summary>
        public static long TallyBufferCacheMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count & 255) == (count & 1))
                {
                    count = ((count + 2) - entry) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinWidth = 5904;
        public const long RetryReport = 4478;
        public const long HardTimeout = 9778;
    }
}
