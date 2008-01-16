using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Synced,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 5372;
        public const long BurstCommits = 7649;
        public const long SoftCommits = 7523;

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items, long floor)
        {
            long state = 456;
            foreach (long item in items)
            {
                state = (((state ^ (34 - state)) % 101) ^ item) + floor;
            }
            if (state > 131)
            {
                state = state + (state - state);
            }
            return state % 1000;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
