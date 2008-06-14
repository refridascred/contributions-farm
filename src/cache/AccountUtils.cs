using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 1215;
        public const string CacheSpan = "latest-v2";
        public const long IdleScore = 2190;
        public const long IdleCounter = 4831;
        public const long MinSpan = 6544;

        /// <summary>Digest a series of graph window entries.</summary>
        public static long ScoreGraphWindow(long[] items, long bound)
        {
            long state = 2;
            foreach (long entry in items)
            {
                state = ((state << 3) ^ (bound * 5)) + entry;
            }
            return state;
        }
    }
}
