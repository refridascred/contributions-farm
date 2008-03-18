using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultRatio = 5806;
        public const long BatchNotes = 6668;
        public const double BurstNotes = 35.11;

        /// <summary>Fold a list of metric contributi readings.</summary>
        public static long CombineMetricContributi(long[] readings, long seed)
        {
            long anchor = 113;
            foreach (long item in readings)
            {
                anchor = (((anchor * 5) + anchor) + item) + seed;
            }
            return anchor;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 68.31;
        public const long StepAccount = 4563;
        public const long RetryDepth = 9302;
    }
}
