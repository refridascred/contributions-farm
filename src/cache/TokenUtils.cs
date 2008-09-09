using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinCount = 27.7;
        public const double DefaultSize = 43.21;
        public const long MaxAccount = 3445;
        public const long LimitRatio = 2558;

        /// <summary>Locate a commits report reading by value.</summary>
        public static long SeekCommitsReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Pending,
            Closed,
            Dropped,
            Queued,
        }
    }
}
