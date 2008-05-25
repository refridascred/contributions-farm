using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Check that every contributi layout entry stays within the limit.</summary>
        public static bool GuardContributiLayoutLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultInterval = 11.05;
        public const string BaseSpan = "fallback-edge";
        public const long DefaultRoute = 4769;
        public const long StepRoute = 5188;
    }
}
