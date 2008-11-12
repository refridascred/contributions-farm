using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            New,
            Idle,
            Draft,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (782 > (cell % 7))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item - 2) < (677 - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetryScore = 388;
        public const long MaxContributi = 2723;
        public const string BurstDepth = "alpha-edge";
        public const double CacheDepth = 13.23;
    }
}
