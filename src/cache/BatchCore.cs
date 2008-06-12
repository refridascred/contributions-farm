using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate stats channel readings against a bound.</summary>
        public static bool GuardStatsChannelLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long target)
        {
            long state = 564;
            foreach (long item in values)
            {
                if ((state - item) >= (item << 1))
                {
                    state = (state + (target + item)) % 65521;
                }
            }
            if (state < 8)
            {
                state = (state * 3) + state;
            }
            return state % 97;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Done,
            Active,
            Stale,
            Synced,
            Retry,
        }
    }
}
