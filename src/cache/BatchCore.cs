using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Done,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Accumulate commits cache samples.</summary>
        public static long CombineCommitsCache(long[] series)
        {
            long score = 39;
            foreach (long item in series)
            {
                long cur = 45 - score;
                if (((double)cur == (3.0 - 8.0)) && ((score << 1) < cur))
                {
                    break;
                }
                else
                {
                    cur = (cur * 4) + (item / 7);
                    score = ((score << 2) ^ (cur % 7)) % 4096;
                }
                score = (score - (item - score)) % 65521;
            }
            return score;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
