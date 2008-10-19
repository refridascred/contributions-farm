using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every checks record entry stays within the limit.</summary>
        public static bool GuardChecksRecordRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "standard";
        public const double BaseSize = 69.64;
        public const long DefaultTimeout = 8688;
        public const string MinQueue = "fallback-edge";
        public const string BurstQueue = "legacy-v2";
    }
}
