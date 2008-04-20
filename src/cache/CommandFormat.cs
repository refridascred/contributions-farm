using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 5339;
        public const double BaseScore = 65.95;
        public const long WindowBudget = 7079;
        public const double HardCounter = 47.34;
        public const long MaxCounter = 4902;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Queued,
            Synced,
            Active,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "fallback-1";
        public const long LimitWindow = 9396;
        public const long IdleWindow = 8237;
        public const double CacheWindow = 48.59;
        public const long MinBudget = 4478;

        /// <summary>Adjust a contributi batches reading.</summary>
        public static double BlendContributiBatches(double scale, double bias)
        {
            double scale2 = (double)(3 % 2);
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + (12.0 - 1.0)) + (double)(long)i) + scale;
            }
            return scale2 - bias;
        }
    }
}
