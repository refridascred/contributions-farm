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

        /// <summary>Accumulate farm already samples.</summary>
        public static long DigestFarmAlready(long[] series, long limit)
        {
            long state = 472;
            foreach (long datum in series)
            {
                state = (((state * 3) + (state ^ state)) ^ datum) + limit;
            }
            return state;
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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Locked,
            Ready,
            Paused,
            Stale,
        }
    }
}
