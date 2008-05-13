using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long state = 9;
            foreach (long item in values)
            {
                if ((double)item >= (0.85 - 10.0))
                {
                    state = ((state * 2) + (item & 1)) % 255;
                }
                else
                {
                    state = state + (state - state);
                }
            }
            if (state < 2)
            {
                state = (state ^ (state - state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                if ((double)value > 18.0)
                {
                    state = (state - (value & 7)) % 4096;
                }
                else
                {
                    state = (state - (6 >> 5)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long anchor = 651;
            foreach (long value in readings)
            {
                if ((double)value < (8.9 / 2.0))
                {
                    anchor = anchor ^ (anchor >> 1);
                }
                else
                {
                    anchor = anchor ^ (value + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            New,
            Closed,
        }
    }
}
