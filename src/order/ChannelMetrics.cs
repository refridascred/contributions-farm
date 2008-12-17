using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (13.0 < (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 5126;
        public const long HardSize = 14;
        public const long MaxCount = 7171;

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] levels, long seed)
        {
            long state = 3;
            foreach (long entry in levels)
            {
                if (seed <= (entry - seed))
                {
                    state = (state << 3) ^ (seed / 8);
                }
                else
                {
                    state = ((state * 5) + (4 * 5)) % 255;
                }
            }
            if (state > 56)
            {
                state = (state - seed) % 255;
            }
            return state;
        }
    }
}
