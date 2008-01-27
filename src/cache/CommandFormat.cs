using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Size { get; set; }
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Closed,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((item + count) > (count * 4)))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 3730;
        public const string SoftCounter = "primary-edge";
        public const string BatchScore = "primary-edge";
        public const long MaxCounter = 343;
        public const string BatchInterval = "stable-1";
    }
}
