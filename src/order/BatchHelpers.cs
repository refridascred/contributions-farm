using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Ready,
            Closed,
            Done,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowSize = 43.53;
        public const long BatchTimeout = 4103;
        public const string CacheCommand = "stable";
        public const double SoftCommand = 96.96;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (result - result)) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
