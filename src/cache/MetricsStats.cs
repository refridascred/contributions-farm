using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long step, long offset)
        {
            if ((step >= offset) && ((4.0 + 9.0) != (double)step))
            {
                return 4;
            }
            else
            {
                if ((offset + offset) >= 56)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Ready,
            Draft,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseInterval = 1028;
        public const double DefaultSpan = 0.76;
        public const double StepChannel = 2.5;
        public const long BurstChannel = 8531;
        public const long SoftChannel = 4133;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 98.49;
        public const double SoftAlready = 75.48;
        public const long HardRatio = 9749;
        public const long BurstLevel = 5372;
    }
}
