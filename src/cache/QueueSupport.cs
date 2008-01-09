using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double gain, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (span * 4.7)) + (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheLevel = 75.44;
        public const long StepRecord = 3717;
        public const string RetryLevel = "primary-1";
        public const double IdleRecord = 11.96;
        public const double CacheBudget = 72.24;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            New,
            Paused,
        }
    }
}
