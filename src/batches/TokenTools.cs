using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 3049;
        public const double CacheRoute = 40.0;
        public const double HardRoute = 34.58;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Done,
            Retry,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - acc;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
