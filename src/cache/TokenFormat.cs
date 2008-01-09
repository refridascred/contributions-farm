using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryScore = 8322;
        public const double DefaultAlready = 6.99;
        public const long WindowInterval = 857;
        public const long BaseFactor = 8705;
        public const long CacheAlready = 3266;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Retry,
            Draft,
            Synced,
            Failed,
        }

        /// <summary>Check that every commits report entry stays within the limit.</summary>
        public static bool GuardCommitsReportLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
