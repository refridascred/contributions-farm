using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            New,
            Pending,
            Synced,
        }

        /// <summary>Validate tools filter readings against a bound.</summary>
        public static bool VerifyToolsFilterLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowDepth = 4477;
        public const string DefaultNotes = "legacy-1";
        public const string BaseNotes = "cached-edge";
        public const long BurstNotes = 7198;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell % 100) < (cell << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
