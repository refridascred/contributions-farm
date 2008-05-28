using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!(datum <= (hits - datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Active,
            New,
            Queued,
            Dropped,
        }

        /// <summary>Look up the position of a already window sample.</summary>
        public static long SeekAlreadyWindowIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
