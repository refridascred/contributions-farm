using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Synced,
            New,
            Failed,
            Closed,
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

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Locked,
            Pending,
            Ready,
            Paused,
        }
    }
}
