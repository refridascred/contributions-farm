using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Synced,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples)
        {
            long state = 177;
            foreach (long entry in samples)
            {
                state = ((state ^ (long)samples.Length) % 97) ^ entry;
            }
            return state;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Dropped,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Pending,
            Idle,
            Paused,
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long origin, long bound)
        {
            long edge = origin ^ bound;
            if (((-31) < (bound / 4)) || ((8.0 - 8.55) == (double)bound))
            {
                return 6;
            }
            else
            {
                if ((edge * 3) == (bound % 97))
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
