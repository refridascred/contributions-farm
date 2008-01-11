using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of buffer stream entries.</summary>
        public static long FoldBufferStream(long[] data, long seed)
        {
            long state = 290;
            foreach (long datum in data)
            {
                state = state ^ (state + state);
                if ((state - datum) >= seed)
                {
                    state = state ^ (state - seed);
                }
                else
                {
                    state = (state ^ (10 ^ (long)data.Length)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRatio = 9864;
        public const double SoftFactor = 10.98;
        public const long BurstCount = 830;

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
