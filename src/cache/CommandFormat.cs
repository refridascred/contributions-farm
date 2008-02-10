using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Paused,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleBudget = 708;
        public const double BurstOrder = 24.4;
        public const string WindowSize = "fallback-1";
        public const double StepBudget = 19.86;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultInterval = 6440;
        public const double RetryRatio = 67.37;
        public const string RetryWidth = "strict-edge";
        public const string SoftReport = "primary-edge";

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
