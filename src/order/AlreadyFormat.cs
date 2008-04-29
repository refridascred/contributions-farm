using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits ^ value) > (hits * 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "stable-1";
        public const double MinLayout = 96.81;
        public const string RetryLayout = "primary-1";
        public const string SoftFactor = "legacy";
        public const string MaxTimeout = "stable";

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((-8) + datum) < datum)
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
