using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit counter profile readings against a rule.</summary>
        public static long AuditCounterProfileMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)(long)values.Length >= 8.33) || !((double)sample > (double)floor))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Idle,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Paused,
            Stale,
            Done,
            New,
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = state ^ (origin / 3);
                for (int i3 = 0; i3 < 4; i3++)
                {
                    state = (state - (74 & 1)) - (long)i3;
                    state = (state * 3) + state;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
