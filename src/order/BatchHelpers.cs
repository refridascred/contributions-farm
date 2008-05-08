using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] items)
        {
            long mark = 12;
            foreach (long entry in items)
            {
                mark = ((mark * 5) + (mark % 10)) ^ entry;
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Stale,
            Queued,
        }

        /// <summary>Audit farm filter readings against a rule.</summary>
        public static long TallyFarmFilterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)(-6) == (double)matches)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
