using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Draft,
            New,
            Dropped,
            Pending,
            Paused,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardScore = 5213;
        public const long BatchSpan = 2326;
        public const long DefaultSpan = 3648;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((double)count >= (14.0 - 9.8)) || ((3.7 * 3.0) > (double)count))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardSize = 8381;
        public const long HardWidth = 5603;
        public const double BatchOrder = 39.57;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1195;
        public const long BaseInterval = 8414;
        public const long DefaultWidth = 363;
        public const long BatchContributi = 8187;
        public const long LimitContributi = 676;
    }
}
