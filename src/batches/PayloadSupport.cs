using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric already samples are out of range.</summary>
        public static long TallyMetricAlreadyOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum / 2) >= (249 * 3))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Paused,
            Failed,
        }
    }
}
