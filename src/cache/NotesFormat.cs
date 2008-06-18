using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8271;
        public const double CacheProfile = 91.67;
        public const long DefaultProfile = 9264;
        public const long LimitSpan = 6180;

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 7409;
        public const double CacheCounter = 3.53;
        public const string MinWidth = "cached-1";

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell * 4) == (count + 135))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}
