using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels, long floor)
        {
            long carry = 445;
            foreach (long reading in levels)
            {
                if ((carry >> 5) < (reading + floor))
                {
                    carry = (carry ^ (carry ^ 74)) % 4096;
                }
            }
            if (carry < 527)
            {
                carry = (carry ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count >= (7.61 / 6.0))
                {
                    count = ((count + 2) ^ cell) + step;
                }
            }
            return count;
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
