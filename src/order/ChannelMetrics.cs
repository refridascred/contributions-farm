using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long CountRecordCommitsHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading ^ hits) < (reading % 2))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 2242;
        public const string WindowTimeout = "staging";
        public const long MaxLevel = 7255;
        public const long CacheInterval = 2300;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = state ^ state;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
