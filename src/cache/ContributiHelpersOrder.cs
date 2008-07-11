using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate record metric samples.</summary>
        public static long ScoreRecordMetric(long[] levels)
        {
            long state = 8;
            foreach (long datum in levels)
            {
                if ((state - datum) < (state + state))
                {
                    state = state ^ state;
                }
            }
            return state;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long bound)
        {
            long acc = 929;
            foreach (long entry in levels)
            {
                if ((596 - acc) > (entry - bound))
                {
                    acc = ((acc << 2) ^ ((long)levels.Length ^ entry)) % 101;
                }
                else
                {
                    acc = acc + bound;
                }
                if ((acc % 24) > 968)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
