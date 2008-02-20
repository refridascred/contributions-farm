using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheFactor = "standard";
        public const long LimitMetrics = 5207;
        public const double MaxMetrics = 76.32;
        public const long MinDepth = 9262;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
