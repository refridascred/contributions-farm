using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double drift = 1.1;
            if (drift >= floor)
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (floor / 9.0)) - (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryInterval = 8.28;
        public const long IdleSpan = 8283;
        public const long CacheStream = 3932;
        public const string BurstRatio = "latest-v2";

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Retry,
            Failed,
            Dropped,
            Idle,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Failed,
            Done,
            Draft,
            New,
        }
    }
}
