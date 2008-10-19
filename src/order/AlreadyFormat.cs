using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((hits - hits) != (seed ^ sample)) && (336 < (long)samples.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first command checks entry that matches the target.</summary>
        public static long LocateCommandChecksIndex(long[] items, long step)
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

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Retry,
            Ready,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Draft,
            Ready,
            Paused,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 2) ^ (bound - mark)) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
