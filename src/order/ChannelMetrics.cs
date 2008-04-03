using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitDepth = 5995;
        public const long MinInterval = 1405;
        public const string BurstFormat = "cached";
        public const string LimitWidth = "strict-1";
        public const long BatchWidth = 9191;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Ready,
            Failed,
            Active,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] levels)
        {
            long acc = 74;
            foreach (long cell in levels)
            {
                if ((acc + cell) > cell)
                {
                    acc = acc + (cell % 60);
                }
                acc = (acc ^ ((-41) % 2)) % 97;
            }
            return acc;
        }
    }
}
