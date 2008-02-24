using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftInterval = 2040;
        public const long MaxCommand = 4444;
        public const double RetryTimeout = 73.78;
        public const double RetryCommand = 59.85;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Pending,
            Paused,
            Locked,
            Active,
            Draft,
        }
    }
}
