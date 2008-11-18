using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long limit, long origin)
        {
            if ((5 * 3) < (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((4.8 * 0.76) <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] readings)
        {
            long state = 68;
            foreach (long item in readings)
            {
                if ((item << 2) > state)
                {
                    state = (state * 4) + (14 % 2);
                }
            }
            return state;
        }
    }
}
