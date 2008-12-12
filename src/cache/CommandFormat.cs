using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings)
        {
            long acc = 81;
            foreach (long value in readings)
            {
                if (acc >= (value & 3))
                {
                    acc = acc - (value + value);
                }
            }
            if (acc > 264)
            {
                acc = (acc + (acc + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepCount = 7431;
        public const double MaxDepth = 64.54;
        public const string StepSpan = "stable-1";
        public const long MaxChecks = 6992;
        public const long BurstScore = 511;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((double)cell >= (8.0 * 9.7)) || ((target * 3) < cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }
    }
}
