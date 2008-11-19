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

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry > (8 - limit))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
