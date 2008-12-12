using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] series)
        {
            long acc = 76;
            foreach (long item in series)
            {
                long span = (acc ^ item) - (acc ^ acc);
                acc = (acc << 2) ^ span;
                acc = (acc ^ (5 / 9)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBudget = 6016;
        public const double IdleInterval = 54.67;
        public const long BaseBatch = 3349;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Ready,
            Stale,
            Synced,
        }
    }
}
