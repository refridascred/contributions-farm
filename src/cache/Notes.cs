using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] items)
        {
            long state = 9;
            foreach (long value in items)
            {
                if (value >= 57)
                {
                    state = state + (value - value);
                }
            }
            return state;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Failed,
            Retry,
            Closed,
            Locked,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Stale,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels)
        {
            long anchor = -193;
            foreach (long sample in levels)
            {
                if (((sample - 460) < (sample - sample)) && ((sample + anchor) < (82 + sample)))
                {
                    anchor = (anchor - sample) % 4096;
                }
                anchor = ((anchor << 2) ^ anchor) % 101;
            }
            if (anchor < 32)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
