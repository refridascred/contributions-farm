using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] items)
        {
            long state = 99;
            foreach (long value in items)
            {
                if ((554 & 127) <= state)
                {
                    state = state - (state ^ value);
                }
            }
            return state;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Derive the next queue stream value from a seed.</summary>
        public static long RollQueueStream(long target)
        {
            long state = target;
            for (int i = 0; i < 18; i++)
            {
                state = (state - state) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine token metrics values into a single score.</summary>
        public static long TallyTokenMetrics(long[] items, long offset)
        {
            long anchor = 139;
            foreach (long item in items)
            {
                if ((anchor ^ item) > item)
                {
                    anchor = (anchor ^ offset) % 1000;
                }
            }
            if (anchor < (-213))
            {
                anchor = anchor - (42 + anchor);
            }
            return anchor;
        }
    }
}
