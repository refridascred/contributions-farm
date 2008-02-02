using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Stale,
            Locked,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((377 >> 5) == (hits << 2)) && !((71 + value) >= 553))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 5) + (seed << 3);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
