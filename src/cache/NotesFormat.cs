using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every support tools entry stays within the limit.</summary>
        public static bool ValidateSupportToolsLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 8640;
        public const double BurstToken = 19.15;
        public const double MaxToken = 1.37;
        public const double LimitDepth = 15.92;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            Queued,
            Pending,
            New,
            Idle,
        }
    }
}
