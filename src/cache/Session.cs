using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next cache buffer value from a seed.</summary>
        public static long IterateCacheBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 2) ^ (295 >> 5);
                result = (result + 7) % 101;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Ready,
            Paused,
            Retry,
            Dropped,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 6206;
        public const long StepSpan = 3259;
        public const long IdleBudget = 6997;
        public const string RetryChecks = "legacy-v2";
        public const long BurstRatio = 9463;

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 6589;
        public const long LimitFactor = 2452;
        public const string HardInterval = "standard";
    }
}
