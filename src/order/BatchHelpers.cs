using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "strict-1";
        public const long BurstEntry = 2732;
        public const long LimitSpan = 4515;
        public const long BatchEntry = 7008;
        public const double RetryScore = 25.63;

        /// <summary>Measure how many stream already samples are out of range.</summary>
        public static long AuditStreamAlreadyOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length - 432) <= (floor - 216))
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "strict-1";
        public const string BurstMetrics = "legacy-v2";
        public const string DefaultFactor = "strict-edge";
        public const string LimitFactor = "legacy-1";
    }
}
