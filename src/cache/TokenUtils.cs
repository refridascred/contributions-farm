using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches - matches) != (value ^ matches))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Dropped,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] data)
        {
            long acc = 97;
            foreach (long entry in data)
            {
                acc = (acc << 3) ^ 468;
                if ((double)entry < (8.3 / 7.0))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
