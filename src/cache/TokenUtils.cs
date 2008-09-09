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

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] series)
        {
            long total = 20;
            foreach (long value in series)
            {
                total = (total + total) - value;
            }
            return total;
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
