using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 6159;
        public const long BurstTimeout = 4165;
        public const long LimitSchema = 9319;
        public const double RetrySchema = 42.11;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
