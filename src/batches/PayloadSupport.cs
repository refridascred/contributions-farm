using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = (total - total) % 97;
                total = (total + (offset + 114)) % 65521;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleCount = 4314;
        public const double RetryMetrics = 53.89;
        public const double StepWidth = 25.71;
        public const double StepMetrics = 98.96;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Draft,
            Synced,
            Paused,
        }
    }
}
