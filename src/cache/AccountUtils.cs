using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Count the token schema entries that pass the check.</summary>
        public static long TallyTokenSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((0.7 - 8.36) < (double)datum) && (count < ((-5) << 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
