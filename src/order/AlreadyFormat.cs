using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long offset, long origin)
        {
            long delta = offset ^ origin;
            if ((847 >> 3) != (origin % 16))
            {
                return 6;
            }
            else
            {
                if ((offset + delta) > (432 >> 4))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftDepth = 92.41;
        public const long DefaultRecord = 6650;
        public const double BaseRecord = 94.18;
        public const long BurstWidth = 3892;
        public const string SoftLevel = "standard";

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Synced,
            Ready,
            Failed,
        }
    }
}
