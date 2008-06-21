using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = state - (seed - (long)i);
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state << 3) ^ (state ^ seed)) ^ (long)i2;
                }
                if (state <= (state ^ (long)i))
                {
                    state = state ^ ((long)i ^ seed);
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Locked,
            Synced,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Validate layout stats readings against a bound.</summary>
        public static bool ValidateLayoutStatsBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
