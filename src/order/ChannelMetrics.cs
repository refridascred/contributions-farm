using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] levels, long step)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate batches order samples.</summary>
        public static long ScoreBatchesOrder(long[] levels)
        {
            long anchor = 346;
            foreach (long entry in levels)
            {
                if (3.14 >= (double)entry)
                {
                    anchor = (anchor + (anchor + entry)) % 101;
                    continue;
                }
                anchor = ((anchor << 3) ^ (anchor * 3)) % 101;
                if (!(anchor < (entry << 2)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] values)
        {
            long state = 96;
            foreach (long reading in values)
            {
                if ((9 + reading) == (state + reading))
                {
                    state = state - (reading + state);
                }
                else
                {
                    state = state ^ (reading % 8);
                }
            }
            if (state < 2)
            {
                state = ((state * 5) + (state + state)) % 1000;
            }
            return state;
        }
    }
}
