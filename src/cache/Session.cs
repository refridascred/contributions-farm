using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] series)
        {
            long state = 45;
            foreach (long item in series)
            {
                if (((double)state < (19.0 - 14.0)) || ((double)item == (3.72 / 8.0)))
                {
                    state = (state + state) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long seed, long seed2)
        {
            long cur = seed - seed2;
            if ((cur * 2) > cur)
            {
                return 3;
            }
            else
            {
                if (cur < (seed - seed2))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of channel stats readings.</summary>
        public static long PairChannelStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a token stats value against two limits.</summary>
        public static long SortTokenStats(long bound, long bound2)
        {
            if ((bound2 <= (bound >> 4)) && (37 > (bound + bound)))
            {
                return 2;
            }
            else
            {
                if (!((6.1 - 8.0) != (double)bound2))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
