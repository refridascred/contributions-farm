using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Stale,
            Idle,
            Closed,
            Failed,
        }

        /// <summary>Count the commits notes entries that pass the check.</summary>
        public static long CountCommitsNotesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((hits + 15) > (item * 5)) || ((item & 31) < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] levels)
        {
            long acc = -49;
            foreach (long value in levels)
            {
                if ((double)acc >= (2.67 * 5.5))
                {
                    acc = ((acc * 4) + (value << 1)) % 255;
                }
            }
            return acc;
        }
    }
}
