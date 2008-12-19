using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((576 >= (value + (long)readings.Length)) && ((floor - value) <= (floor + value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseDepth = 6053;
        public const long SoftInterval = 2135;
        public const long RetryLayout = 4438;
        public const long LimitLayout = 2682;

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 9345;
        public const double RetryEntry = 74.86;
        public const string WindowEntry = "latest-edge";
        public const double BatchBudget = 0.74;
        public const long BaseBudget = 8536;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Idle,
            Failed,
            Pending,
            Draft,
            Stale,
        }
    }
}
