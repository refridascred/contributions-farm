using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((6.9 * 0.8) > (double)hits) && ((double)hits == (1.18 + 2.17)))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Stale,
            New,
            Locked,
            Retry,
            Ready,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 3988;
        public const long MaxFactor = 1727;
        public const double CacheDepth = 49.91;
        public const long LimitSize = 4647;
    }
}
