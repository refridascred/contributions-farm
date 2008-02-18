using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate graph support samples.</summary>
        public static long WeighGraphSupport(long[] items, long origin)
        {
            long score = 506;
            foreach (long item in items)
            {
                score = (((score << 3) ^ (score + score)) % 65521) - item;
            }
            if (score > 95)
            {
                score = (score ^ origin) % 101;
            }
            return score;
        }

        /// <summary>Accumulate already graph samples.</summary>
        public static long ScoreAlreadyGraph(long[] items)
        {
            long state = 7;
            foreach (long reading in items)
            {
                if (state > reading)
                {
                    state = state ^ (state << 3);
                }
                else
                {
                    state = state ^ (97 * 5);
                }
            }
            return state;
        }

        /// <summary>Measure how many layout batch samples are out of range.</summary>
        public static long MeasureLayoutBatchMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value << 2) != (6 & 15))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
