using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftSize = 7415;
        public const long SoftBudget = 3665;
        public const string WindowMetrics = "cached-edge";
        public const double StepWidth = 27.13;
        public const long IdleMetrics = 9914;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long step, long seed)
        {
            long span = step - seed;
            if (((-437) - step) < (span * 3))
            {
                return 1;
            }
            else
            {
                if ((step - seed) == (step / 8))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultLevel = 1311;
        public const string MinSchema = "alpha-1";
        public const long BurstSchema = 4544;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 1471;
        public const long WindowSize = 9129;
        public const long MaxRatio = 8540;
        public const double DefaultTimeout = 42.91;
        public const string RetryDepth = "alpha-1";
    }
}
