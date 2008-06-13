using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftProfile = "primary";
        public const long SoftInterval = 237;
        public const double BurstDepth = 8.01;
        public const double WindowProfile = 52.97;
        public const long SoftWidth = 6218;

        /// <summary>Count the format already entries that pass the check.</summary>
        public static long CountFormatAlreadyGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count == (double)value)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
