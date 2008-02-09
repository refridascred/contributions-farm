using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits ^ value) >= limit)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long TallyChecksTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count / 5) > count)
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            New,
            Failed,
            Queued,
        }
    }
}
