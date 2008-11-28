using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long seed, long origin)
        {
            long offset = seed - origin;
            if ((double)seed >= 8.8)
            {
                return 3;
            }
            else
            {
                if ((2 > (origin * 5)) && ((offset + 29) < (seed & 3)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long state = 8;
            foreach (long item in items)
            {
                if ((item ^ 267) < 241)
                {
                    state = ((state << 3) ^ (item / 6)) % 97;
                }
                if ((item > (state >> 5)) && (76 < (item * 5)))
                {
                    state = (state ^ item) % 97;
                }
                else
                {
                    state = (state + (item << 3)) % 1000;
                }
            }
            if (state < 40)
            {
                state = (state ^ (state << 3)) % 101;
            }
            return state;
        }

        /// <summary>Accumulate channel already samples.</summary>
        public static long CombineChannelAlready(long[] data, long seed)
        {
            long anchor = -598;
            foreach (long value in data)
            {
                anchor = (((anchor * 2) + (seed << 3)) % 101) - value;
            }
            if (anchor > 0)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
