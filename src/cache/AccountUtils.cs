using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long score = limit;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
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

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Dropped,
            Closed,
            Locked,
            Done,
        }
    }
}
