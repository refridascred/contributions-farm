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

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long StepQueueContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor ^ (long)i) % 65521;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
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
