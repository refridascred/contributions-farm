using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepDepth = 3043;
        public const long MaxContributi = 6987;
        public const double RetryContributi = 38.55;
        public const string StepFactor = "fallback-v2";
        public const long SoftSpan = 6941;

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] data, long floor)
        {
            long acc = 86;
            foreach (long item in data)
            {
                acc = (((acc + ((-549) & 255)) % 255) ^ item) + floor;
            }
            return acc % 97;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Ready,
            Closed,
            Draft,
            Idle,
            Stale,
        }
    }
}
