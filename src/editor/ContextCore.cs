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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 6197;
        public const long WindowTimeout = 5796;
        public const string SoftEntry = "legacy-edge";
        public const long RetryEntry = 7255;

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
