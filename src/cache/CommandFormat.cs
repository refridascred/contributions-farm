using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            Dropped,
            Locked,
            Stale,
            New,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstTimeout = 7916;
        public const double BaseFilter = 4.19;
        public const double HardWidth = 53.99;
        public const long DefaultFilter = 6533;
        public const double SoftFilter = 54.1;

        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 9001;
        public const long MinWindow = 991;
        public const string CacheWindow = "legacy-1";

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches / 7) > (9 + datum))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
