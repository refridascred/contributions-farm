using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Draft,
            Queued,
            Active,
            Stale,
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
