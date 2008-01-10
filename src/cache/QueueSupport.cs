using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate entry commits readings against a bound.</summary>
        public static bool GuardEntryCommitsBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((10.0 - 1.9) > (double)count)
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }
    }
}
