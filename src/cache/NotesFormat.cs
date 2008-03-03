using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every batches graph entry stays within the limit.</summary>
        public static bool GuardBatchesGraphLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 97.76;
        public const long CacheOrder = 1281;
        public const double BurstSpan = 46.1;
        public const double RetryWidth = 70.96;
        public const long MinFactor = 8514;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 1148;
        public const double BaseEditor = 94.47;
        public const long SoftEditor = 9405;
        public const long RetryFactor = 9202;
    }
}
