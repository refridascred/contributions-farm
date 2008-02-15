using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 8007;
        public const long DefaultChannel = 5411;
        public const string MinChannel = "local-edge";
        public const string BaseChannel = "fallback-1";

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleSpan = "alpha-edge";
        public const string BurstStats = "alpha-v2";
        public const string BurstCount = "primary";

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardInterval = 1578;
        public const long CacheStream = 5244;
        public const long RetryStream = 650;
        public const long StepTimeout = 942;
        public const long BaseStream = 8098;
    }
}
