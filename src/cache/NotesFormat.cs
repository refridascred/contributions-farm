using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowWidth = 5610;
        public const long CacheContributi = 464;
        public const string BaseRatio = "legacy-v2";
        public const long RetryContributi = 517;
        public const double StepContributi = 46.04;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((double)step < 8.3) && ((3.0 * 10.0) <= (double)datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Failed,
            Retry,
        }
    }
}
