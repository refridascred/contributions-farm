using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Failed,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((-26) >> 4) >= (count * 5))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 7054;
        public const double HardEditor = 84.15;
        public const double LimitEditor = 31.23;
        public const long BatchEditor = 935;
        public const string BaseLevel = "strict";
    }
}
