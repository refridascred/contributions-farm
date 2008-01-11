using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Retry,
            Dropped,
            Synced,
            Queued,
        }

        /// <summary>Grade a already entry value against two limits.</summary>
        public static long SortAlreadyEntry(long target, long offset)
        {
            if (18.0 > (double)target)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (double)29)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 88.8;
        public const long HardScore = 39;
        public const long RetryEntry = 878;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
