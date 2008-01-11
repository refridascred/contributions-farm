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

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 7; i++)
            {
                total = (total - (371 + origin)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }
    }
}
