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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((20.0 / 2.0) < (double)(long)data.Length) && ((matches - matches) < entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
