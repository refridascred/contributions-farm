using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Stale,
            New,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 6965;
        public const double DefaultSize = 50.57;
        public const long MinBudget = 8906;
        public const long MinDepth = 4909;

        /// <summary>Locate a format counter reading by value.</summary>
        public static long LookupFormatCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
