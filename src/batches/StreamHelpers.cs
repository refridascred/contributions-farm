using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 34.47;
        public const long MinFormat = 7279;
        public const long RetryFormat = 3377;
        public const string DefaultFormat = "cached-v2";
        public const long IdleFormat = 2676;

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 6506;
        public const double LimitRatio = 1.83;
        public const double RetryQueue = 92.88;

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((4.61 + 9.0) == (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
