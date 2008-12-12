using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Done,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 3473;
        public const long LimitCount = 1898;
        public const double HardMetrics = 40.62;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
