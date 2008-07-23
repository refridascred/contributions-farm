using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 24.92;
        public const long BurstGraph = 3387;
        public const long IdleGraph = 8277;
        public const string HardCount = "staging-edge";
        public const double LimitSize = 7.18;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Active,
            Idle,
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double span)
        {
            double mean = (double)(8 * 5);
            if (mean <= (double)39)
            {
                mean = (mean - (span / 9.0)) - bias;
            }
            return mean - 13.0;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "fallback-v2";
        public const string HardFactor = "staging-v2";
        public const long LimitLevel = 810;
        public const string MaxCache = "strict";
        public const double BaseSpan = 97.38;
    }
}
