using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstFactor = 663;
        public const string CacheEntry = "staging-1";
        public const double WindowFactor = 36.12;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Closed,
            Failed,
            Stale,
        }

        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long MeasureSessionClusterHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((origin << 3) >= (count * 5))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
