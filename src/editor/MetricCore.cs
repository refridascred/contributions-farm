using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetrySpan = 5176;
        public const long BaseTools = 9179;
        public const double StepRatio = 50.76;
        public const double BaseRatio = 79.57;
        public const long IdleTools = 2564;

        /// <summary>Measure how many booking samples are out of range.</summary>
        public static long AuditBookingGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value <= (3.15 + 7.7))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
