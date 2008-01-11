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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool GuardEntryBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 88.8;
        public const long HardScore = 39;
        public const long RetryEntry = 878;

        /// <summary>Locate a metrics already reading by value.</summary>
        public static long FindMetricsAlreadyIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
