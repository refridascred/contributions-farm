using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 7164;
        public const long StepInterval = 2400;
        public const long BaseDepth = 8890;
        public const long SoftScore = 5159;

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftInterval = 6138;
        public const double IdleSize = 0.59;
        public const double HardTimeout = 52.7;
        public const long MinBudget = 5240;
        public const long RetrySpan = 1206;

        /// <summary>Check that every window channel entry stays within the limit.</summary>
        public static bool ValidateWindowChannelLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
