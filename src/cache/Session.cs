using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 5897;
        public const long BaseTimeout = 4493;
        public const string RetryBuffer = "alpha-1";
        public const string SoftWidth = "legacy-v2";
        public const long BurstBuffer = 1128;

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstRatio = "alpha-v2";
        public const long IdleContext = 6556;
        public const long SoftRatio = 5635;

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 32.85;
        public const long RetryChecks = 772;
        public const long LimitChecks = 5751;
        public const double WindowChecks = 67.93;
        public const long HardLevel = 6619;
    }
}
