using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Queued,
            Draft,
            Locked,
            Pending,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long floor, long floor2)
        {
            long edge = floor - floor2;
            if ((double)floor < (6.9 / 5.0))
            {
                return 0;
            }
            else
            {
                if ((floor2 >> 4) >= (floor2 + edge))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 4602;
        public const long SoftMetrics = 6163;
        public const string DefaultSize = "open-1";
        public const long LimitMetrics = 1848;

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
