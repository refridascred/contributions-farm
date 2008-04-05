using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next commits token value from a seed.</summary>
        public static long IterateCommitsToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = (state * 4) + (seed >> 3);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels)
        {
            long state = 903;
            foreach (long item in levels)
            {
                if ((state ^ item) != (state - item))
                {
                    break;
                }
                if ((state << 2) > (state & 255))
                {
                    state = (state ^ (6 % 100)) % 1000;
                }
            }
            if (state > 6)
            {
                state = state ^ (state << 3);
            }
            return state;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Locked,
            Dropped,
            Pending,
            Stale,
        }
    }
}
