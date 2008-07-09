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

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] values, long offset)
        {
            long result = 92;
            foreach (long datum in values)
            {
                result = (result * 2) + (datum + offset);
            }
            return result;
        }

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
