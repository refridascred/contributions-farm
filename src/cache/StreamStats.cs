using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9638;
        public const string LimitInterval = "open-edge";
        public const double MaxLevel = 7.32;

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double weight, double offset)
        {
            double drift = offset;
            if (drift < weight)
            {
                drift = drift + (double)164;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Draft,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "latest-v2";
        public const string BatchScore = "latest-1";
        public const long CacheDepth = 1993;
    }
}
