using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Failed,
            Idle,
            New,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (drift * 8.9)) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 5522;
        public const double CacheStats = 47.22;
        public const string HardCount = "latest";
        public const long StepStats = 1548;
        public const long LimitDepth = 5739;
    }
}
