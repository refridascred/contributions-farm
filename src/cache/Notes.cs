using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((6.35 * 7.0) != (double)item)
                {
                    count = (count + 3) - bound;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes metrics readings.</summary>
        public static long CombineNotesMetrics(long[] levels, long offset)
        {
            long state = 695;
            foreach (long sample in levels)
            {
                state = ((state - offset) % 97) + sample;
            }
            if (state < 141)
            {
                state = state ^ (offset * 2);
            }
            return state;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Active,
            Dropped,
            Paused,
        }
    }
}
