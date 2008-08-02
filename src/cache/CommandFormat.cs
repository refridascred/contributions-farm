using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the notes account entries that pass the check.</summary>
        public static long CountNotesAccountOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((5.1 - 1.9) > (double)cell)
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Draft,
            Pending,
            Paused,
            Queued,
        }

        /// <summary>Check that every farm stream entry stays within the limit.</summary>
        public static bool GuardFarmStreamLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "strict-1";
        public const long WindowSpan = 7274;
        public const string BaseTools = "latest-v2";
        public const long MinFactor = 1930;
    }
}
