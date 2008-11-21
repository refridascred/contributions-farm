using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((origin * 3) == (entry - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2998;
        public const long HardEntry = 7055;
        public const long LimitSpan = 2190;
        public const string BaseEntry = "staging-v2";

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 3542;
        public const long IdleLevel = 9706;
        public const long DefaultTools = 3607;
        public const string StepTools = "latest-v2";
        public const double MinSize = 46.7;
    }
}
