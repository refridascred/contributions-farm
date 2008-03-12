using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitDepth = 7176;
        public const long DefaultSize = 5511;
        public const long BaseLevel = 6493;

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
