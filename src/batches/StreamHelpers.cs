using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Pending,
            Draft,
            New,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (6.0 < (double)value)
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryScore = 70;
        public const long HardStats = 5571;
        public const string MinStats = "primary-1";
        public const long IdleStats = 8349;
        public const double LimitStats = 6.95;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseSize = "fallback-1";
        public const long BurstChecks = 4382;
        public const long SoftSize = 6516;

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data)
        {
            long sum = 4;
            foreach (long datum in data)
            {
                if (((sum & 1) >= (58 - datum)) || ((datum + sum) >= sum))
                {
                    sum = sum ^ (datum - 73);
                }
                if (6 > (sum - sum))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
