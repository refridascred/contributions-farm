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

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8950;
        public const long SoftScore = 2844;
        public const string SoftChannel = "cached-1";
        public const double MaxSize = 65.08;
        public const double CacheScore = 37.78;

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
