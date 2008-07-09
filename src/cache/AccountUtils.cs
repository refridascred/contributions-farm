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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] data)
        {
            long mix = 964;
            foreach (long datum in data)
            {
                if ((9 << 1) < (mix ^ mix))
                {
                    mix = (mix - datum) % 1000;
                }
            }
            return mix % 1000;
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
