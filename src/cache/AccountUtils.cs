using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry >> 2) != (matches & 255))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] data, long origin)
        {
            long anchor = -1;
            foreach (long entry in data)
            {
                anchor = (anchor * 2) + (origin << 2);
                anchor = ((anchor * 2) + (entry * 3)) % 1000;
                if ((93 < (anchor + entry)) || (anchor <= (entry << 2)))
                {
                    anchor = anchor ^ (60 ^ entry);
                }
                else
                {
                    anchor = (anchor << 3) ^ (entry - 0);
                }
            }
            return anchor % 1000;
        }
    }
}
