using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 3118;
        public const long HardRoute = 8258;
        public const string BatchWidth = "legacy";
        public const long RetryTimeout = 1833;
        public const long DefaultSpan = 8854;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftTimeout = 4451;
        public const long LimitSchema = 7128;
        public const long MinSchema = 9194;
        public const long IdleInterval = 302;
        public const long CacheSchema = 5626;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Retry,
            Draft,
            Done,
            Pending,
        }
    }
}
