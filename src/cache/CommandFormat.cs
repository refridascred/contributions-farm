using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 3709;
        public const long IdleRatio = 8051;
        public const long CacheCount = 3525;
        public const double LimitRatio = 36.09;
        public const long CacheLevel = 1678;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Pending,
            Locked,
            Stale,
            Ready,
            Active,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Draft,
            Paused,
            Synced,
            Pending,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
