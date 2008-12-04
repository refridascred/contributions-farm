using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultTimeout = 4340;
        public const long BurstCluster = 9259;
        public const long SoftCluster = 1802;

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "alpha";
        public const long LimitLevel = 1425;
        public const long BaseWindow = 8227;
        public const long MinSpan = 5956;
        public const long HardWindow = 7046;

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool ValidateMetricsSchemaBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Stale,
            Paused,
            Pending,
            Queued,
        }
    }
}
