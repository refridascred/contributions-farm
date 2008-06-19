using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheBudget = "legacy";
        public const double WindowInterval = 42.3;
        public const long DefaultBudget = 2700;
        public const long IdleStream = 8480;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 791;
        public const long IdleSize = 3516;
        public const long BurstBuffer = 7119;
    }
}
