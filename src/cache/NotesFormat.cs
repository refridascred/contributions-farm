using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Retry,
            Locked,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 101;
        public const long IdleQueue = 4263;
        public const long SoftBudget = 9705;
        public const long BaseBudget = 9178;

        /// <summary>Validate checks support readings against a bound.</summary>
        public static bool CheckChecksSupportRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
