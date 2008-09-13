using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Idle,
            Done,
            Synced,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultCount = 89.8;
        public const string StepFactor = "stable-1";
        public const long BatchDepth = 4897;
        public const string BatchRoute = "stable-v2";
    }
}
