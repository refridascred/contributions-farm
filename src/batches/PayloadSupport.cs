using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 4671;
        public const long WindowInterval = 6082;
        public const double RetryCount = 37.79;

        /// <summary>Check that every graph metrics entry stays within the limit.</summary>
        public static bool GuardGraphMetricsLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
