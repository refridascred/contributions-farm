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

        /// <summary>Classify a session metrics pair into a bucket.</summary>
        public static long BucketSessionMetrics(long seed, long target)
        {
            if (!((target * 3) != (seed / 8)))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= 3.0)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

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
